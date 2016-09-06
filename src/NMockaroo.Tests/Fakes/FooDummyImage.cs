using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooDummyImage
    {
        [MockarooDummyImageUrl(Format = DummyImageFormats.Gif, MaxHeight = 500, MaxWidth = 500, MinHeight = 250,
             MinWidth = 250, Name = "FooDummyImageUrl", PercentBlank = 0, Type = DataTypes.DummyImageUrl)]
        public string FooDummyImageUrl { get; set; }
    }
}
