using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooAvatar
    {
        [MockarooAvatar(Height = 500, Name = "Avatar", PercentBlank = 0, Type = DataTypes.Avatar, Width = 500)]
        public string Avatar { get; set; }
    }
}
