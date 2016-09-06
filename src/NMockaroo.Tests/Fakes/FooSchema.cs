using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    class FooSchema
    {
        [MockarooInfo(Name = "Id", Type = DataTypes.Number)]
        public int Id { get; set; }

    }
}
