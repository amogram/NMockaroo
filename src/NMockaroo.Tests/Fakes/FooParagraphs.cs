using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooParagraphs
    {
        [MockarooParagraphs(Min = 2, Max = 4, Name = "summary", PercentBlank = 0, Type = DataTypes.Paragraphs)]
        public string Summary { get; set; }
    }
}