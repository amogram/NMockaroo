namespace NMockaroo.Attributes
{
    /// <summary>
    /// Represents the Avatar Datatype.
    /// <see cref="https://mockaroo.com/api/docs#type_avatar" />
    /// </summary>
    public class MockarooAvatarAttribute : MockarooInfoAttribute
    {
        /// <summary>
        /// The image height in pixels
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// The image width in pixels
        /// </summary>
        public int Width { get; set; }
    }
}
