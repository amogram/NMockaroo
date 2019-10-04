using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooWebsite
    {
        [MockarooUrl(IncludeHost = true, IncludePath = false, IncludeProtocol = true, 
            IncludeQueryString = false, Name = "url", PercentBlank = 0, Type = DataTypes.Url)]
        public string Url { get; set; }
    }
}
