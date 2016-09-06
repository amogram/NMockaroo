# Change Log
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/) 
and this project attempts to adhere to [Semantic Versioning](http://semver.org/).

## [Unreleased]
### Added
- Nothing yet.

## [1.0.0] - 2016-09-06
### Added
- New datatypes: Avatar, DummyImageUrl, SqlExpression, AppBundleID, AppName, AppVersion, Base64ImageUrl, IPAddressV6CIDR, LinkedInSkill, NaughtyString, PoissonDistribution, SHA1, SHA256. 
- New attributes for datatypes: Avatar, DummyImageUrl, JsonArray, SqlExpression.
- Web Proxy capabaility from [@cannontrodder](https://github.com/cannontrodder).
- Shema Support from [@matabares](https://github.com/matabares).
- No need to explicity declare the name in the MockarooInfoAttribute anymore.  If it's empty, the property name will be used instead.

### Changed
- Attempting to follow [SemVer](http://semver.org) properly. 
- Updated Copyright year in assembly information and README
- Updated dependencies on Json.NET and NUnit.
- Better documentation for Attributes.  Referes to Mockaroo API documentation.

## [0.1.0] - 2015-03-05
### Added
- Initial release.
