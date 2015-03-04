using System;
using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooTime
    {
        [MockarooTime(Name = "logintime", PercentBlank = 0, Type = DataTypes.Time)]
        public DateTime LoginTime { get; set; }
    }
}
