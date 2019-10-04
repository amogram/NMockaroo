namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Poisson Distribution Datatype.
    /// <see cref="https://mockaroo.com/api/docs#type_poisson_distribution" /> 
    /// </summary>
    public class MockarooPoissonDistributionAttribute : MockarooInfoAttribute
    {
        public int Mean { get; set; }
    }
}
