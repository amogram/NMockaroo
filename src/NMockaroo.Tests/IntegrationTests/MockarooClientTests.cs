using NMockaroo.Exceptions;
using NMockaroo.Tests.Fakes;
using NUnit.Framework;

namespace NMockaroo.Tests.IntegrationTests
{
    [TestFixture]
    public class MockarooClientTests
    {
        [Test]
        public void InvalidApiKey_ThrowsInvalidApiKeyException()
        {
            Assert.Throws<MockarooException>(() =>
            {
                var api = new MockarooClient("potato999");

                api.GetData<FooBar>(2);
            });
        }
    }
}