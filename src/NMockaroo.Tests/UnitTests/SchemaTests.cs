using System.Linq;
using NMockaroo.Tests.Fakes;
using NUnit.Framework;

namespace NMockaroo.Tests.UnitTests
{
    [TestFixture]
    public class SchemaTests
    {
        [Test]
        public void Schema_Adds_CanAddFields()
        {
            var schema = new Schema<FooBar>();

            schema.AddField(f => f.FirstName, null);
            schema.AddField(f => f.LastName, null);
            schema.AddField(f => f.DateOfBirth, null);
            schema.AddField(f => f.Soup, null);
            schema.AddField(f => f.Town, null);

            Assert.AreEqual(schema.Fields.Count, 5);
            Assert.IsTrue(schema.Fields.Any(x => x.Name == "FirstName"));
            Assert.IsTrue(schema.Fields.Any(x => x.Name == "LastName"));
            Assert.IsTrue(schema.Fields.Any(x => x.Name == "DateOfBirth"));
            Assert.IsTrue(schema.Fields.Any(x => x.Name == "Soup"));
            Assert.IsTrue(schema.Fields.Any(x => x.Name == "Town"));
        }
    }
}
