using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    ///     Represents the Mockaroo Number type
    /// </summary>
    public class MockarooNumberAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     The minimum value
        /// </summary>
        [DefaultValue(1)]
        public int Min { get; set; }

        /// <summary>
        ///     The maximum value
        /// </summary>
        [DefaultValue(100)]
        public int Max { get; set; }

        /// <summary>
        ///     The number of decimals
        /// </summary>
        [DefaultValue(2)]
        public int Decimals { get; set; }
    }
}