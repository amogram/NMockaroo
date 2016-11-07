using System.Linq;
using NMockaroo.Attributes;
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

        [Test]
        public void Schema_Adds_CanAddFieldsAndDataTypes()
        {
            var schema = new Schema<FooBar>();

            schema.AddField(f => f.FirstName, new MockarooInfo
            {
                Type = DataTypes.FirstName
            });

            schema.AddField(f => f.LastName, new MockarooInfo
            {
                Type = DataTypes.LastName,
                PercentBlank = 18
            });

            schema.AddField(f => f.DateOfBirth, new MockarooDate
            {
                Min = "01/01/1970",
                Max = "05/04/2014",
                Type = DataTypes.Date
            });

            schema.AddField(f => f.Soup, new MockarooCustomList
            {
                SelectionStyle = SelectionStyles.Sequential,
                PercentBlank = 0,
                Values =
                    new[]
                    {
                        "Cream of Tomato", "Potato 'and' Leek", "Beef/Pork & Orange", "Chicken (Special Edition)",
                        "Cock O'Leekie"
                    }
            });

            schema.AddField(f => f.Town, new MockarooCustomList
            {
                SelectionStyle = SelectionStyles.Random,
                PercentBlank = 0,
                Values = new[]
                {
                    "Ballymena", "Holywood", "Belfast", "Portrush"
                }
            });

            Assert.AreEqual(schema.Fields.Count, 5);
            Assert.IsTrue(schema.Fields.Any(x => x.Name == "FirstName" && x.DataType is MockarooInfo));
            Assert.IsTrue(schema.Fields.Any(x => x.Name == "LastName" && x.DataType is MockarooInfo));
            Assert.IsTrue(schema.Fields.Any(x => x.Name == "DateOfBirth" && x.DataType is MockarooDate));
            Assert.IsTrue(schema.Fields.Any(x => x.Name == "Soup" && x.DataType is MockarooCustomList));
            Assert.IsTrue(schema.Fields.Any(x => x.Name == "Town" && x.DataType is MockarooCustomList));
        }
    }
}
