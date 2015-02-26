using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooWords
    {
        [MockarooWords(Name = "description", Min = 5, Max = 15,Type = DataTypes.Words, PercentBlank = 0)]
        public string Description { get; set; }
    }
}
