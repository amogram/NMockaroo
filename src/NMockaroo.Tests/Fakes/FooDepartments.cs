using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooDepartments
    {
        [MockarooInfo(Type = DataTypes.DepartmentCorporate)]
        public string CorporateName { get; set; }

        [MockarooInfo(Type = DataTypes.DepartmentRetail)]
        public string RetailName { get; set; }
    }
}
