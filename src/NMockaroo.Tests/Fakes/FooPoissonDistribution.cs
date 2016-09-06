using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooPoissonDistribution
    {
        [MockarooPoissonDistribution(Mean = 50, Name = "Figures", PercentBlank = 0, Type = DataTypes.PoissonDistribution)]
        public string Figures { get; set; }
    }
}
