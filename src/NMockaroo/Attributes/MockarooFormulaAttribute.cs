using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo Formula type
    /// <see cref="http://www.mockaroo.com/api/docs#type_formula" />
    /// </summary>
    public class MockarooFormulaAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     The string value representing the formula
        /// </summary>
        public string Value { get; set; }
    }
}