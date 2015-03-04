using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    ///     Represents the Mockaroo State type
    /// </summary>
    public class MockarooStateAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     True to restrict locations to the United States
        /// </summary>
        [DefaultValue(false)]
        public bool OnlyUSPlaces { get; set; }
    }
}