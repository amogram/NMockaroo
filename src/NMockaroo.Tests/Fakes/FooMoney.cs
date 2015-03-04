using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooMoney
    {
        [MockarooInfo(Name = "FirstName", Type = DataTypes.FirstName)]
        public string FirstName { get; set; }

        [MockarooInfo(Name = "LastName", Type = DataTypes.LastName)]
        public string LastName { get; set; }

        [MockarooMoney(Name = "Salary", Min = 20000, Max = 40000, PercentBlank = 0, Symbol = "random", Type = DataTypes.Money)]
        public string Salary { get; set; }
    }
}
