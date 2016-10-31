namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo Geometric Distribution type
    /// <see cref="https://www.mockaroo.com/api/docs#type_geometric_distribution" />
    /// </summary>
    public class MockarooGeometricDistributionAttribute : MockarooInfoAttribute
    {
        /// <summary>
        /// The probability of success
        /// </summary>
        public decimal Probability { get; set; }
    }
}
