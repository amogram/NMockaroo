# NMockaroo

[![Build Status](https://img.shields.io/appveyor/ci/amogram/nmockaroo/master.svg?style=flat-square)](https://ci.appveyor.com/project/amogram/nmockaroo)
[![Version](https://img.shields.io/nuget/v/NMockaroo.svg?style=flat-square)](https://www.nuget.org/packages?q=NMockaroo)
[![license](https://img.shields.io/badge/license-MIT%20License-blue.svg?style=flat-square)](https://github.com/amogram/NMockaroo/blob/master/LICENSE)

NMockaroo is a little library that provides an easy way for you to generate mock data based on your C# objects using the Mockaroo API.

## Available on NuGet

Run the following command in the Package Manager Console:

```
PM> Install-Package NMockaroo
```

## Example Usage

Suppose you have a Person object like this:

```csharp
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
}
```

Use the library of attributes in NMockaroo to define your Person Schema in Mockaroo:

```csharp
public class Person
{
	[MockarooInfo(Type = DataTypes.FirstName)]
	public string FirstName { get; set; }

	[MockarooInfo(Type = DataTypes.LastName)]
	public string LastName { get; set; }

	[MockarooInfo(Type = DataTypes.EmailAddress, PercentBlank = 40)]
	public string Email { get; set; }

	[MockarooCustomList(
		PercentBlank = 0,
		Type = DataTypes.CustomList,
		Values = new[] { "Super User", "Administrator", "Manager", "Employee" },
		SelectionStyle = "sequential")]
	public string Role { get; set; }
}
```

Then use MockarooClient to generate your mock data:

```csharp
var client = new MockarooClient(YOUR_API_KEY);
var people = client.GetData<Person>(10).ToArray();
```

Easy peasy.


## Using NMockroo from behind a Web Proxy

From version 1.0.0, NMockaroo has web proxy support.  When instantiating your MockarooClient object, you can declare your WebProxy details as follows:

```csharp
var client = new MockarooClient(YOUR_API_KEY)
{
	Proxy = new WebProxy
	{
		Address = new Uri("http://web-proxy-url"),
		// ...
	}
};
```


## Building on your own Machine

NMockaroo is a single assembly designed to be easy to deploy anywhere.  If you prefer to compile it yourself, you will need:

 * Visual Studio 2015 (Community Edition is more than enough)
 * Windows 7 or newer
 

## Contributing

NMockaroo is hosted [on GitHub](https://github.com/amogram/nmockaroo).  If you find a bug, please visit the issue tracker and report the issue.

Feel free to submit a pull request containing any improvemenets, bug fixes or new features. 


P.S. A huge thanks to [Mockaroo](https://mockaroo.com), without which this library would not exist.

## License

Copyright © 2016 Andrew McCaughan and other contributors.

Distributed under the [MIT License](http://en.wikipedia.org/wiki/MIT_License).

[![](https://codescene.io/projects/4049/status.svg) Get more details at **codescene.io**.](https://codescene.io/projects/4049/jobs/latest-successful/results)

