using System;
using System.Configuration;
using System.Linq;
using NMockaroo.Tests.Fakes;
using NUnit.Framework;

namespace NMockaroo.Tests.UnitTests
{
    [TestFixture]
    internal class MockarooClientUnitTests : ConfiguredFixture
    {
        private int _numberOfInstances;

        [OneTimeSetUp]
        public void Init()
        {
            _numberOfInstances = 1;
        }
        
        [Test]
        public void NoApiKey_ThrowsNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new MockarooClient(null));
        }

        [Test]
        public void MockarooClient_WhenValidKey_ReturnsData()
        {
            var client = new MockarooClient(ApiKey);
            var foo = client.GetData<FooBar>(_numberOfInstances);
            Assert.IsTrue(foo.Count() == _numberOfInstances);
        }

        [Test]
        public void MockarooClient_WhenSchemaNameIsRequested_ReturnsSchemaData()
        {
            var client = new MockarooClient(ApiKey);
            var foo = client.GetSchemaData<FooSchema>(_numberOfInstances, "UnitTest");
            Assert.IsTrue(foo.Count() == _numberOfInstances);
        }
    }
}