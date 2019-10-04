namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo Regular Expression type.
    /// <see cref="https://mockaroo.com/api/docs#type_regular_expression" />
    /// <seealso cref="https://github.com/benburkert/randexp" />
    /// </summary>
    public class MockarooRegularExpressionAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     The following character classes are supported:
        ///     \d	numbers
        ///     \w	words from lorem ipsum
        ///     [:alpha:]	letters
        ///     [:upper:]	uppercase letters
        ///     [:lower:]	lowercase letters
        ///     [:name:]	random first and last name
        ///     [:first_name:]	random first name
        ///     [:last_name:]	random last name
        ///     [:plus:]	+
        ///     [:question:]	?
        ///     {{my_field}}	Value of field named "my field"
        /// </summary>
        public string Value { get; set; }
    }
}