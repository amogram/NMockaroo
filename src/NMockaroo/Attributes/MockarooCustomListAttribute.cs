using System.Collections.Generic;

namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo Custom List.
    /// <see cref="http://mockaroo.com/api/docs#type_custom_list" />
    /// </summary>
    public class MockarooCustomListAttribute : MockarooAttribute
    {
        public string[] Values { get; set; }

        public string SelectionStyle { get; set; }
    }

    public static class SelectionStyles
    {
        public const string Random = "random";
        public const string Sequential = "sequential";
        public const string Custom = "custom";
        public const string Cartesian = "cartesian";
    }
}