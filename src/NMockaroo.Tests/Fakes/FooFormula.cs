using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooFormula
    {
        [MockarooFormula(Name = "Concatenated", Type = DataTypes.Formula, Value = @"""hello "" + ""world""")]
        public string Concatenated { get; set; }
    }
}