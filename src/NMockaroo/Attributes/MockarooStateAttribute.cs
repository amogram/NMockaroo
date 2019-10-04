using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo State type
    /// <see cref="https://mockaroo.com/api/docs#type_state"/>
    /// </summary>
    public class MockarooStateAttribute : MockarooInfoAttribute
    {
        /// <summary>
        /// True to restrict locations to the United States
        /// </summary>
        [DefaultValue(false)]
        public bool OnlyUSPlaces { get; set; }
    }
}