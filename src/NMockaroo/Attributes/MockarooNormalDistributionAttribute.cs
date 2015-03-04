using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    ///     Represents the Mockaroo Normal Distribution type
    /// </summary>
    public class MockarooNormalDistributionAttribute : MockarooInfoAttribute
    {
        [DefaultValue(0)]
        public double Mean { get; set; }

        [DefaultValue(2)]
        public int Decimals { get; set; }
    }
}