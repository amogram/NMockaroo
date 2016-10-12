using System;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using NMockaroo.Tests.Fakes;
using NUnit.Framework;

namespace NMockaroo.Tests.IntegrationTests
{
    [TestFixture]
    public class MockarooAttributeTests
    {
        private readonly string _apiKey = ConfigurationManager.AppSettings["MockarooApiKey"];

        [Test]
        public void GetData_ReturnsCorrectInfo()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooBars = mockaroo.GetData<FooBar>(10).ToList();

            Assert.AreEqual(fooBars.Count, 10);
            
            fooBars.ForEach(foobar =>
            {
                Assert.IsNotEmpty(foobar.FirstName);
                Assert.IsNotEmpty(foobar.Town);
            });
        }

        [Test]
        public void GetData_ReturnsValidDateTime()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooBars = mockaroo.GetData<FooBar>(10).ToList();
            var fooBar = fooBars.First();

            Assert.AreNotEqual(fooBar.DateOfBirth, DateTime.MinValue);
        }

        [Test]
        public void GetData_ReturnsValidListOfValues()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var values = new[] { "Ballymena", "Holywood", "Belfast", "Portrush" };
            var fooBars = mockaroo.GetData<FooBar>(10).ToList();

            fooBars.ForEach(foo =>
            {
                Assert.Contains(foo.Town, values);
            });
        }

        [Test]
        public void GetData_ReturnsValidListWithSpecialCharacters()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooBars = mockaroo.GetData<FooBar>(10).ToList();
            string[] values = { "Cream of Tomato", "Potato 'and' Leek", "Beef/Pork & Orange", "Chicken (Special Edition)", "Cock O'Leekie" };

            fooBars.ForEach(foo =>
            {
                Assert.Contains(foo.Soup, values);
            });
        }

        [Test]
        public void GetData_ReturnsValidMoney()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooMonies = mockaroo.GetData<FooMoney>(10).ToList();

            fooMonies.ForEach(foo =>
            {
                Assert.Contains(foo.Salary.ToCharArray().First(), new[] { '£', '$', '€', '¥' });
            });
        }

        [Test]
        public void GetData_ReturnsValidNumber()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooMonies = mockaroo.GetData<FooNumbers>(50).ToList();

            fooMonies.ForEach(foo =>
            {
                Assert.GreaterOrEqual(foo.Quantity, 1);
                Assert.LessOrEqual(foo.Quantity, 10);
            });
        }

        [Test]
        public void GetData_ReturnsValidNormalDistribution()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooDists = mockaroo.GetData<FooDist>(10).ToList();

            Assert.AreEqual(fooDists.Count, 10);

            fooDists.ForEach(foobar =>
            {
                Assert.GreaterOrEqual(foobar.RowNumber, 0);
            });
        }

        [Test]
        public void GetData_ReturnsValidSentences()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooSentences = mockaroo.GetData<FooSentences>(10).ToList();

            fooSentences.ForEach(fooSentence =>
            {
                var sentences = fooSentence.Summary.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Assert.LessOrEqual(sentences.Count(), 3); 
                Assert.GreaterOrEqual(sentences.Count(), 1);
            });
        }

        [Test]
        public void GetData_ReturnsParagraphs()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooParagraphs = mockaroo.GetData<FooParagraphs>(10).ToList();

            fooParagraphs.ForEach(fooParagraph =>
            {
                var paragraphs = fooParagraph.Summary.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Assert.LessOrEqual(paragraphs.Count(), 4);
                Assert.GreaterOrEqual(paragraphs.Count(), 2);
            });
        }

        [Test]
        public void GetData_ReturnsFormula()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooFormulas = mockaroo.GetData<FooFormula>(1).ToList();

            Assert.AreEqual(fooFormulas.Count(), 1);
            Assert.AreEqual("hello world", fooFormulas[0].Concatenated);
        }

        [Test]
        public void GetData_ReturnsOneOrZeroItems()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooFormulas = mockaroo.GetData<FooFormula>(0).ToList();
            Assert.AreEqual(fooFormulas.Count(), 0);
            fooFormulas = mockaroo.GetData<FooFormula>(1).ToList();
            Assert.AreEqual(fooFormulas.Count(), 1);
        }

        [Test]
        public void GetData_ReturnsValidRegex()
        {
            const string regexPattern = @"Aa{3}h{3,15}!";

            var mockaroo = new MockarooClient(_apiKey);
            var fooRegexes = mockaroo.GetData<FooRegex>(10).ToList();

            fooRegexes.ForEach(fooregex =>
            {
                Assert.IsTrue(Regex.IsMatch(fooregex.Bar, regexPattern));
            });
        }

        [Test]
        public void GetData_ReturnsValidSequence()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooSequences = mockaroo.GetData<FooSequence>(10).ToList();
            var sequenceCount = 50;

            foreach (FooSequence t in fooSequences.OrderBy(x => x.SequenceCounter))
            {
                Assert.AreEqual(sequenceCount, t.SequenceCounter);
                sequenceCount++;
            }
        }

        [Test]
        public void GetData_ReturnsValidTime()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooTimes = mockaroo.GetData<FooTime>(10).ToList();

            fooTimes.ForEach(fooTime =>
            {
                Assert.IsNotEmpty(fooTime.LoginTime.TimeOfDay.ToString());
            });
        }

        [Test]
        public void GetData_ReturnsValidUrl()
        {
            const string urlRegexPattern = @"^http(s)?://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$";

            var mockaroo = new MockarooClient(_apiKey);
            var fooSites = mockaroo.GetData<FooWebsite>(10).ToList();

            fooSites.ForEach(fooSite =>
            {
                Assert.IsTrue(Regex.IsMatch(fooSite.Url, urlRegexPattern));
            });
        }

        [Test]
        public void GetData_ReturnsValidWords()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooWords = mockaroo.GetData<FooWords>(10).ToList();

            fooWords.ForEach(fooWord =>
            {
                var words = fooWord.Description.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Assert.LessOrEqual(words.Count(), 15);
                Assert.GreaterOrEqual(words.Count(), 5);
            });
        }

        [Test]
        public void GetData_ReturnsValidAvatarImage()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooAvatars = mockaroo.GetData<FooAvatar>(5).ToList();

            fooAvatars.ForEach(fooAvatar =>
            {
                Assert.IsNotEmpty(fooAvatar.Avatar);
            });
        }

        [Test]
        public void GetData_ReturnsValidDummyImageUrl()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooWords = mockaroo.GetData<FooDummyImage>(5).ToList();

            fooWords.ForEach(dummyImage =>
            {
                Assert.IsNotEmpty(dummyImage.FooDummyImageUrl);
            });
        }

        [Test]
        public void GetData_ReturnsValidPoissonDistribution()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooPoissons = mockaroo.GetData<FooPoissonDistribution>(10).ToList();

            fooPoissons.ForEach(fooPoisson =>
            {
                Assert.IsNotEmpty(fooPoisson.Figures);
            });
        }

        [Test]
        public void GetData_ReturnsPropertiesOnlyDecoratedWithMockarooAttribute()
        {
            var mockaroo = new MockarooClient(_apiKey);
            var fooNestedObjects = mockaroo.GetData<FooNestedObject>(10).ToList();

            fooNestedObjects.ForEach(fooNestedObject =>
            {
                Assert.IsNotNull(fooNestedObject.Id);
                Assert.IsNull(fooNestedObject.Details);
                Assert.IsNull(fooNestedObject.ObjectWithAnotherAttribute);
                Assert.IsNotNull(fooNestedObject.Url);
            });
        }
    }
}