using System;
using System.ComponentModel;

namespace NMockaroo.Attributes
{
    public class MockarooInfoAttribute : Attribute
    {
        /// <summary>
        ///     The name of the field. When using json format, you can use "."
        ///     in field names to generate nested json objects, brackets to
        ///     generate arrays.
        ///     <see cref="https://www.mockaroo.com/help/json" />
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     An integer between 0 and 100 that determines what percent of the
        ///     generated values will be null.
        /// </summary>
        [DefaultValue(0)]
        public int PercentBlank { get; set; }

        /// <summary>
        ///     One of Mockaroo's 86 data types.
        /// </summary>
        public virtual string Type { get; set; }

        /// <summary>
        /// Alters the generated value using Mockaroo formula syntax.
        /// Use 'this' to refer to the value of this field.
        /// </summary>
        public string Formula { get; set; }
    }
}