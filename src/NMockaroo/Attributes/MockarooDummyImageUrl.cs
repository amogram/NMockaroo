namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Dummy Image Url Datatype.
    /// <see cref="http://mockaroo.com/api/docs#type_dummy_image_url" />
    /// </summary>
    public class MockarooDummyImageUrlAttribute : MockarooInfoAttribute
    {
        /// <summary>
        /// The minimum height in pixels
        /// </summary>
        public int MinHeight { get; set; }
        
        /// <summary>
        /// The maximum height in pixels
        /// </summary>
        public int MaxHeight { get; set; }

        /// <summary>
        /// The minimum width in pixels
        /// </summary>
        public int MinWidth { get; set; }

        /// <summary>
        /// The maximum width in pixels
        /// </summary>
        public int MaxWidth { get; set; }

        /// <summary>
        /// The image format (random, png, gif or jpg)
        /// </summary>
        public string Format { get; set; }
    }

    /// <summary>
    /// Dummy Image formats for Mockaroo Dummy Image
    /// </summary>
    public class DummyImageFormats
    {
        public const string Random = "random";
        public const string Png = "png";
        public const string Gif = "gif";
        public const string Jpg = "jpg";
    }
}
