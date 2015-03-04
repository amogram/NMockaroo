using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooSequence
    {
        [MockarooSequence(Name = "sequenceCounter", PercentBlank = 0, Repeat = 1, Start = 50, Step = 1, Type = DataTypes.Sequence)]
        public int SequenceCounter { get; set; }
    }
}