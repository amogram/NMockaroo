using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    ///     Represents the Mockaroo Custom List
    /// </summary>
    public class MockarooCustomListAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     An array of values to pick from.  Each value should be a string.
        /// </summary>
        public string[] Values { get; set; }

        /// <summary>
        ///     "random" or "sequential"
        /// </summary>
        [DefaultValue("random")]
        public string SelectionStyle { get; set; }
    }
}