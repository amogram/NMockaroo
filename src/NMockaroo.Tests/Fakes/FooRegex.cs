using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooRegex
    {
        [MockarooRegularExpression(Name = "bar", PercentBlank = 0, Type = DataTypes.RegularExpression, Value = @"Aa{3}h{3,15}!")]
        public string Bar { get; set; }
    }
}