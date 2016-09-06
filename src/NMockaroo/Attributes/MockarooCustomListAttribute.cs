using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo Custom List.
    /// <see cref="http://mockaroo.com/api/docs#type_custom_list" />
    /// </summary>
    public class MockarooCustomListAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     An array of values to pick from.  Each value should be a string.
        /// </summary>
        public string[] Values { get; set; }

        /// <summary>
        /// "random", "sequential", "custom", or "cartesian"
        /// </summary>
        [DefaultValue("random")]
        public string SelectionStyle { get; set; }
    }

    public class SelectionStyles
    {
        public const string Random = "random";
        public const string Sequential = "sequential";
        public const string Custom = "custom";
        public const string Cartesian = "cartesian";
    }
}