[![Build Status](https://img.shields.io/appveyor/ci/amogram/nmockaroo/master.svg?style=flat-square)](https://ci.appveyor.com/project/amogram/nmockaroo)

# NMockaroo

NMockaroo is a little library that provides an easy way for you to generate mock data based on your C# objects using the Mockaroo API.


## Example Usage

Suppose you have a Person object like this:

```
public class Person
{
	public string FirstName {get;set;}
    public string LastName {get;set;}
    public string Email {get;set;}
    public string Role {get;set;}
}
```

Use the library of attributes in NMockaroo to define your Person Schema in Mockaroo:

```
public class Person
{
	[MockarooInfo(Name = "FirstName", Type = DataTypes.FirstName)]
	public string FirstName { get; set; }

	[MockarooInfo(Name = "LastName", Type = DataTypes.LastName)]
	public string LastName { get; set; }

	[MockarooInfo(Name = "Email", Type = DataTypes.EmailAddress, PercentBlank = 40)]
	public string Email { get; set; }

	[MockarooCustomList(
		Name = "Role",
		PercentBlank = 0,
		Type = DataTypes.CustomList,
		Values = new[] { "Super User", "Administrator", "Manager", "Employee" },
		SelectionStyle = "sequential")]
	public string Role { get; set; }
}
```

Then use MockarooClient to generate your mock data:

```
...
var client = new MockarooClient(YOUR_API_KEY);
var people = client.GetData<Person>(10).ToArray();
...

```

Easy peasy.


## Building on your own Machine

NMockaroo is a single assembly designed to be easy to deploy anywhere.  If you prefer to compile it yourself, you will need:

 * Visual Studio 2013 (Community Edition will be fine)
 * Windows 7 or newer
 

## Contributing

NMockaroo is hosted [on GitHub](https://github.com/amogram/nmockaroo).  If you find a bug, please visit the issue tracker and report the issue.

Feel free to submit a pull request containing any improvemenets, bug fixes or new features. 


P.S. A huge thanks to [Mockaroo](https://mockaroo.com), without which this library would not exist.

## License

Copyright © 2015 Andrew McCaughan

Distributed under the [MIT License](http://en.wikipedia.org/wiki/MIT_License)