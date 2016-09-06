using System;
using System.Configuration;
using System.Linq;
using NMockaroo.Tests.Fakes;
using NUnit.Framework;

namespace NMockaroo.Tests.UnitTests
{
    [TestFixture]
    internal class MockarooClientUnitTests
    {
        public string ApiKey { get; set; }
        public int NumberOfInstances { get; set; }

        [OneTimeSetUp]
        public void Init()
        {
            ApiKey = ConfigurationManager.AppSettings["MockarooApiKey"];
            NumberOfInstances = 1;
        }

        [Test]
        public void NoApiKey_ThrowsNullException()
        {
            // ReSharper disable once ObjectCreationAsStatement
            Assert.Throws<ArgumentNullException>(() => new MockarooClient(null));
        }

        [Test]
        public void MockarooClient_WhenValidKey_ReturnsData()
        {
            var client = new MockarooClient(ApiKey);
            var foo = client.GetData<FooBar>(NumberOfInstances);
            Assert.IsTrue(foo.Count() == NumberOfInstances);
        }

        [Test]
        public void MockarooClient_WhenSchemaNameIsRequested_ReturnsSchemaData()
        {
            var client = new MockarooClient(ApiKey);
            var foo = client.GetSchemaData<FooSchema>(NumberOfInstances, "UnitTest");
            Assert.IsTrue(foo.Count() == NumberOfInstances);
        }
    }
}