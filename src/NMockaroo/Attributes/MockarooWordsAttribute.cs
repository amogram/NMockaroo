using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo Words type.
    /// <see cref="https://mockaroo.com/api/docs#type_words"/>
    /// </summary>
    public class MockarooWordsAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     The minimum number of words
        /// </summary>
        [DefaultValue(10)]
        public int Min { get; set; }

        /// <summary>
        ///     The maximum number of words
        /// </summary>
        [DefaultValue(20)]
        public int Max { get; set; }
    }
}