namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Country Data type. 
    /// <see cref="http://mockaroo.com/api/docs#type_country" />
    /// </summary>
    public class MockarooCountryAttribute
    {
        /// <summary>
        /// An array of countries to restrict the generated locations to
        /// </summary>
        public string[] Countries { get; set; }
    }
}
