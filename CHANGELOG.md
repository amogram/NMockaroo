# Change Log
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/) 
and this project attempts to adhere to [Semantic Versioning](http://semver.org/).

## [Unreleased]
### Added 
- Support for new datatypes: University, Department (Retail), Department (Corporate), geomatric, binomial and exponential distributions, and ICD10 diagnosis and procedure codes. 

## [1.0.0.57] - 2016-10-16
### Fixed
- [Issue #5](https://github.com/amogram/NMockaroo/issues/5) - Properties and objects that don't have Mockaroo attributes were not being ignored.  Also picked up another issue that non-Mockaroo attributes were not being ignored.

### Changed
- Updated dependencies on NUnit.

## [1.0.0] - 2016-09-06
### Added
- New datatypes: Avatar, DummyImageUrl, SqlExpression, AppBundleID, AppName, AppVersion, Base64ImageUrl, IPAddressV6CIDR, LinkedInSkill, NaughtyString, PoissonDistribution, SHA1, SHA256. 
- New attributes for datatypes: Avatar, DummyImageUrl, JsonArray, SqlExpression.
- Web Proxy capability from [@cannontrodder](https://github.com/cannontrodder).
- Schema Support from [@matabares](https://github.com/matabares).
- No need to explicitly declare the name in the MockarooInfoAttribute anymore.  If it's empty, the property name will be used instead.

### Changed
- Attempting to follow [SemVer](http://semver.org) properly. 
- Updated Copyright year in assembly information and README
- Updated dependencies on Json.NET and NUnit.
- Better documentation for Attributes.  Refers to Mockaroo API documentation.

## [0.1.0] - 2015-03-05
### Added
- Initial release.
