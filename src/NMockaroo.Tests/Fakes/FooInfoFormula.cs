using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooInfoFormula
    {
        [MockarooInfo(Name = "Name", Formula = "if (this=='foo') then 'FOO'")]
        public string Name { get; set; }
    }
}
