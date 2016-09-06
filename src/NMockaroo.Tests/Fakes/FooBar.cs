using System;
using NMockaroo.Attributes;

namespace NMockaroo.Tests.Fakes
{
    public class FooBar
    {
        [MockarooCustomList(
            PercentBlank = 0,
            Type = DataTypes.CustomList,
            Values = new[] { "Ballymena", "Holywood", "Belfast", "Portrush" })]
        public string Town { get; set; }

        [MockarooInfo(Name = "FirstName", Type = DataTypes.FirstName)]
        public string FirstName { get; set; }

        [MockarooInfo(Type = DataTypes.LastName)]
        public string LastName { get; set; }

        [MockarooDate(Name = "DateOfBirth", Min = "01/01/1970", Max = "05/04/2014", Type = DataTypes.Date)]
        public DateTime DateOfBirth { get; set; }

        [MockarooCustomList(
            Name = "Soup",
            PercentBlank = 0,
            Type = DataTypes.CustomList,
            Values = new[] { "Cream of Tomato", "Potato 'and' Leek", "Beef/Pork & Orange", "Chicken (Special Edition)", "Cock O'Leekie" },
            SelectionStyle = "sequential")]
        public string Soup { get; set; }
    }
}