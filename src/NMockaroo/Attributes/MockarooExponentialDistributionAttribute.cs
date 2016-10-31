namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Exponential Distribution data type
    /// <see cref="https://www.mockaroo.com/api/docs#type_exponential_distribution"/>
    /// </summary>
    public class MockarooExponentialDistributionAttribute
    {
        /// <summary>
        /// The rate parameter
        /// </summary>
        public decimal Lambda { get; set; }
    }
}
