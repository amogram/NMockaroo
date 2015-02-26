using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooSentences
    {
        [MockarooSentences(Max = 3, Min = 1, Name = "summary", PercentBlank = 0, Type = DataTypes.Sentences)]
        public string Summary { get; set; }
    }
}
