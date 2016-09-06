using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo Dataset column.
    /// <see cref="http://mockaroo.com/api/docs#type_dataset_column" />
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
        ///     "random", "sequential", "custom", or "cartesian"
        /// </summary>
        [DefaultValue("random")]
        public string SelectionStyle { get; set; }
    }
}