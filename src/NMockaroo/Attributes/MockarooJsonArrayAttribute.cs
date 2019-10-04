using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Json Array Datatype
    /// <see cref="https://mockaroo.com/api/docs#type_json_array" />
    /// <seealso cref="https://mockaroo.com/help/json_arrays" />
    /// </summary>
    public class MockarooJsonArrayAttribute : MockarooInfoAttribute
    {
        /// <summary>
        /// The minimum number of items to generate (0 to 100).
        /// </summary>
        [DefaultValue(1)]
        public int MinItems { get; set; }

        /// <summary>
        /// The maximum number of items to generate (0 to 100)
        /// </summary>
        [DefaultValue(5)]
        public int MaxItems { get; set; }
    }
}
