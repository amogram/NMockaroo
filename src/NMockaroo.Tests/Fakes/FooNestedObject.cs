using System.ComponentModel.DataAnnotations;
using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooNestedObject
    {
        [MockarooInfo(Type = DataTypes.Guid)]
        public string Id { get; set; }

        [MockarooUrl(IncludeHost = true, IncludePath = false, IncludeProtocol = true,
            IncludeQueryString = false, Type = DataTypes.Url)]
        public string Url { get; set; }

        public FooDetails Details { get; set; }

        [Required]
        public string ObjectWithAnotherAttribute { get; set; }
    }

    public class FooDetails
    {
        public string Comment { get; set; }
    }
}
