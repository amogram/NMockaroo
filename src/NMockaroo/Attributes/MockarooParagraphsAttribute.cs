using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    ///     Represents the Mockaroo Paragraphs type
    /// </summary>
    public class MockarooParagraphsAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     The minimum number of paragraphs
        /// </summary>
        [DefaultValue(1)]
        public int Min { get; set; }

        /// <summary>
        ///     The maximum number of paragraphs
        /// </summary>
        [DefaultValue(3)]
        public int Max { get; set; }
    }
}