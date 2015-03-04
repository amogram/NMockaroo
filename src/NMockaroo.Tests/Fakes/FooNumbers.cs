using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooNumbers
    {
        [MockarooNumber(Decimals = 0, Max = 10, Min = 1, Name = "quantity", PercentBlank = 0, Type = DataTypes.Number)]
        public int Quantity { get; set; }
    }
}