using System.ComponentModel;

namespace NMockaroo
{
    public class MockarooCustomList : MockarooInfo
    {
        /// <summary>
        ///     An array of values to pick from.  Each value should be a string.
        /// </summary>
        public string[] Values { get; set; }

        /// <summary>
        /// "random", "sequential", "custom", or "cartesian"
        /// </summary>
        [DefaultValue("random")]
        public string SelectionStyle { get; set; }
    }
}
