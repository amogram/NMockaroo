using System;

namespace NMockaroo.Attributes
{
    public class MockarooAttribute : Attribute, IDataType
    {
        public string Name { get; set; }
        public int PercentBlank { get; set; }
        public string Type { get; set; }
        public string Formula { get; set; }
    }
}
