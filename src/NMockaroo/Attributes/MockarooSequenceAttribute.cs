using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo Sequence type.
    /// <see cref="https://mockaroo.com/api/docs#type_sequence"/>
    /// </summary>
    public class MockarooSequenceAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     The first number in the sequence
        /// </summary>
        [DefaultValue(1)]
        public int Start { get; set; }

        /// <summary>
        ///     The number to add to each subsequent value
        /// </summary>
        [DefaultValue(1)]
        public int Step { get; set; }

        /// <summary>
        ///     The number of times each value should occur
        ///     before the step amount is added.
        /// </summary>
        [DefaultValue(1)]
        public int Repeat { get; set; }
    }
}