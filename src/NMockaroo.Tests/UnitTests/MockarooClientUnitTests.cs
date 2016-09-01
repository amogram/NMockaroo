using System;
using System.Linq;
using NMockaroo.Tests.Fakes;
using NUnit.Framework;

namespace NMockaroo.Tests.UnitTests
{
    [TestFixture]
    class MockarooClientUnitTests
    {
        public string ApiKey { get; set; }
        public int NumberOfInstances { get; set; }

        [TestFixtureSetUp]
        public void Init()
        {
            ApiKey = "PUT YOUR KEY HERE";
            NumberOfInstances = 1;

        }


        [Test]
        public void NoApiKey_ThrowsNullException()
        {
            // ReSharper disable once ObjectCreationAsStatement
            Assert.Throws<ArgumentNullException>(() => new MockarooClient(null));
        }

        [Test]
        public void MockarooClient_WhenValidKey_ReturnData()
        {
            var client = new MockarooClient(ApiKey);
            var foo = client.GetData<FooBar>(NumberOfInstances);
            Assert.IsTrue(foo.Count() == NumberOfInstances);
        }


        [Test]
        public void MockarooClient_WhenSchemaNameIsRequested_ReturnSchemaData()
        {
            var client = new MockarooClient(ApiKey);
            var foo = client.GetSchemeData<FooSchema>(NumberOfInstances, "demo");
            Assert.IsTrue(foo.Count() == NumberOfInstances);
        }
    }
}
