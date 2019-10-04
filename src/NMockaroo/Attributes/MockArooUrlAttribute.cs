using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Mockaroo Url type
    /// <see cref="https://mockaroo.com/api/docs#type_url"/>
    /// </summary>
    public class MockarooUrlAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     True to include a protocol in the url.
        /// </summary>
        [DefaultValue(true)]
        public bool IncludeProtocol { get; set; }

        /// <summary>
        ///     True to include a protocol in the url
        /// </summary>
        [DefaultValue(true)]
        public bool IncludeHost { get; set; }

        /// <summary>
        ///     True to include a path in the url
        /// </summary>
        [DefaultValue(true)]
        public bool IncludePath { get; set; }

        /// <summary>
        ///     True to include a query string in the url
        /// </summary>
        [DefaultValue(true)]
        public bool IncludeQueryString { get; set; }
    }
}