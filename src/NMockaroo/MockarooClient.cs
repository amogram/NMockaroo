using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NMockaroo.Attributes;
using NMockaroo.Exceptions;

namespace NMockaroo
{
    /// <summary>
    /// A client for the Mockaroo API.  
    /// <see cref="http://www.mockaroo.com/api/docs" />
    /// </summary>
    public class MockarooClient
    {
        private const string MockarooApiUrl = @"http://www.mockaroo.com/api/generate.json?key={0}&count={1}";
        private const string MockarooSchemaApiUrl = @"http://www.mockaroo.com/api/generate.json?key={0}&count={1}&schema={2}";

        private readonly string _apiKey;

        public WebProxy Proxy { get; set; }

        public MockarooClient(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentNullException(nameof(apiKey),
                    "API Key required. Please make sure to specify your API key in your configuration file.");
            }

            _apiKey = apiKey;
        }

        public IEnumerable<T> GetData<T>(int count)
        {
            if (count == 0)
            {
                return new T[0].AsEnumerable();
            }

            IEnumerable<T> data;
            var request = CreateRequest<T>(count);
            var handler = new HttpClientHandler
            {
                Proxy = Proxy
            };

            using (var client = new HttpClient(handler))
            {
                var response = client.SendAsync(request).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new MockarooException(responseContent);
                }

                data = count == 1
                    ? new[] {JsonConvert.DeserializeObject<T>(responseContent)}.AsEnumerable()
                    : JsonConvert.DeserializeObject<IEnumerable<T>>(responseContent);
            }

            return data;
        }


        public IEnumerable<T> GetSchemaData<T>(int count, string schemeName)
        {
            if (count == 0)
            {
                return new T[0].AsEnumerable();
            }

            IEnumerable<T> data;
            var request = CreateSchemeRequest<T>(count, schemeName);
            var handler = new HttpClientHandler {Proxy = Proxy};

            using (var client = new HttpClient(handler))
            {
                var response = client.SendAsync(request).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new MockarooException(responseContent);
                }

                data = count == 1
                    ? new[] {JsonConvert.DeserializeObject<T>(responseContent)}.AsEnumerable()
                    : JsonConvert.DeserializeObject<IEnumerable<T>>(responseContent);
            }

            return data;
        }


        private HttpRequestMessage CreateRequest<T>(int count)
        {
            var fieldMetadata = GetFields<T>().ToArray();

            var jsonSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var jsonString = JsonConvert.SerializeObject(
                fieldMetadata,
                Formatting.None,
                jsonSettings);

            var url = string.Format(MockarooApiUrl, _apiKey, count);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url),
                Content = new StringContent(jsonString)
            };
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return request;
        }

        private HttpRequestMessage CreateSchemeRequest<T>(int count, string schemaName)
        {
            var url = string.Format(MockarooSchemaApiUrl, _apiKey, count, schemaName);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return request;
        }

        private IEnumerable<Dictionary<string, object>> GetFields<T>()
        {
            var fields = typeof(T).GetProperties().Where(p => Attribute.IsDefined(p, typeof(MockarooAttribute)));
            return fields.Select(GetFieldMetadata);
        }

        private static Dictionary<string, object> GetFieldMetadata(PropertyInfo field)
        {
            var customAttributeData = field.GetCustomAttributesData().ToArray();

            Dictionary<string, object> fieldData = null;

            foreach (var data in customAttributeData.Where(data => data.NamedArguments != null && data.NamedArguments.Any()))
            {
                if (data.NamedArguments == null)
                {
                    continue;
                }

                foreach (var arg in data.NamedArguments)
                {
                    if (fieldData == null)
                    {
                        fieldData = new Dictionary<string, object>();
                    }

                    fieldData.Add(arg.MemberInfo.Name, GetValueOrArray(arg.TypedValue));
                }

                if (fieldData != null && fieldData.All(x => x.Key != "Name"))
                {
                    fieldData.Add("Name", field.Name);
                }
            }

            return fieldData;
        }

        private static object GetValueOrArray(CustomAttributeTypedArgument argument)
        {
            if (argument.Value.GetType() == typeof(ReadOnlyCollection<CustomAttributeTypedArgument>))
            {
                return (
                    from cataElement in (ReadOnlyCollection<CustomAttributeTypedArgument>)argument.Value
                    select cataElement.Value.ToString()
                    ).ToArray();
            }

            return argument.Value;
        }
    }
}