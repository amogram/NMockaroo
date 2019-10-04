using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo Custom List.
    /// <see cref="https://mockaroo.com/api/docs#type_custom_list" />
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

    public static class SelectionStyles
    {
        public static readonly string Random = "random";
        public static readonly string Sequential = "sequential";
        public static readonly string Custom = "custom";
        public static readonly string Cartesian = "cartesian";
    }
}