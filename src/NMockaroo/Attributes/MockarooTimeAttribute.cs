using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo Time type
    /// <see cref="http://mockaroo.com/api/docs#type_time"/>
    /// </summary>
    public class MockarooTimeAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     The minimum time in HH:MM AM/PM format
        /// </summary>
        [DefaultValue("12:00 AM")]
        public string Min { get; set; }

        /// <summary>
        ///     The maximum time in HH:MM AM/PM format
        /// </summary>
        [DefaultValue("11:59 PM")]
        public string Max { get; set; }

        /// <summary>
        ///     Optional - The format to output.  This can be any format
        ///     directive supportive by ruby Time.strftime.  Defaults to
        ///     ISO 8601 format. Example: "08:37:48"
        /// </summary>
        [DefaultValue("%T")]
        public string Format { get; set; }
    }
}