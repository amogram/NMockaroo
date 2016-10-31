namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo Geometric Distribution type
    /// <see cref="https://www.mockaroo.com/api/docs#type_binomial_distribution" />
    /// </summary>
    public class MockarooBinomialDistributionAttribute : MockarooInfoAttribute
    {
        /// <summary>
        /// The probability of success
        /// </summary>
        public decimal Probability { get; set; }
    }
}
