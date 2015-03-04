using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    ///     Represents the Mockaroo Money type
    /// </summary>
    public class MockarooMoneyAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     The minimum value
        /// </summary>
        [DefaultValue(0)]
        public int Min { get; set; }

        /// <summary>
        ///     The maximum value
        /// </summary>
        [DefaultValue(10)]
        public int Max { get; set; }

        /// <summary>
        ///     One the following: $, £, €, ¥, random, none
        /// </summary>
        [DefaultValue("$")]
        public string Symbol { get; set; }
    }
}