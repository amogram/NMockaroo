using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooDist
    {
        [MockarooNormalDistribution(Decimals = 0, Name = "RowNumber", PercentBlank = 0, Type = DataTypes.NormalDistribution, Mean = 5)]
        public int RowNumber { get; set; }
    }
}