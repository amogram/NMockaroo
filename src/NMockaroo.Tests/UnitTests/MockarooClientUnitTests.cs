using System;
using NUnit.Framework;

namespace NMockaroo.Tests.UnitTests
{
    [TestFixture]
    class MockarooClientUnitTests
    {
        [Test]
        public void NoApiKey_ThrowsNullException()
        {
            // ReSharper disable once ObjectCreationAsStatement
            Assert.Throws<ArgumentNullException>(() => new MockarooClient(null));
        }
    }
}
