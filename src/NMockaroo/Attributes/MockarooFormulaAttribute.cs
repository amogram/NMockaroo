using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    ///     Represents the Mockaroo Formula type
    ///     See <a href="https://www.mockaroo.com/api/docs#type_formula">here</a> for details
    ///     
    /// </summary>
    public class MockarooFormulaAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     The string value representing the formula
        /// </summary>
        public string Value { get; set; }
    }
}