using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    ///     Represents the Mockaroo Dataset column
    /// </summary>
    public class MockarooDatasetColumnAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     The name of a saved dataset
        /// </summary>
        public string Dataset { get; set; }

        /// <summary>
        ///     The name of the column in the saved dataset
        /// </summary>
        public string Column { get; set; }

        /// <summary>
        ///     "random" or "sequential"
        /// </summary>
        [DefaultValue("random")]
        public string SelectionStyle { get; set; }
    }
}