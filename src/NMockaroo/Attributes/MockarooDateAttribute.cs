using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    ///     Represents the Mockaroo Date type
    /// </summary>
    public class MockarooDateAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     The minimum date in mm/dd/yyyy format.
        ///     Eg. 2/23/2015
        ///     Default Min date is today's date
        /// </summary>
        public string Min { get; set; }

        /// <summary>
        ///     The maximum date in mm/dd/yyyy format.
        ///     Eg. 2/23/2015
        ///     Default Max date is today's date a year ago
        /// </summary>
        public string Max { get; set; }

        /// <summary>
        ///     (optional) The format to output. This can be any format directive
        ///     supported by ruby Time.strftime. Defaults to
        ///     <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO 8601 format</a>.
        ///     Example value: "2007-11-19T08:37:48-06:00".
        /// </summary>
        [DefaultValue("%FT%T%:z")]
        public string Format { get; set; }
    }
}