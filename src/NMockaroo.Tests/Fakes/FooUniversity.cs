using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooUniversity
    {
        [MockarooInfo(Type = DataTypes.FullName)]
        public string StudentName { get; set; }

        [MockarooInfo(Type = DataTypes.University)]
        public string University { get; set; }
    }
}
