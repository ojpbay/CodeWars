using NUnit.Framework;

namespace CodeWars
{
    public class EncodeTextTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SimpleEncode()
        {
            Assert.AreEqual("(((", EncodeText.DuplicateEncode("din"));
        }

        [Test]
        public void EncodeWithDuplicates()
        {
            Assert.AreEqual("()()()", EncodeText.DuplicateEncode("recede"));
        }

        [Test]
        public void EncodeWithMixedCasing()
        {
            Assert.AreEqual(")())())", EncodeText.DuplicateEncode("Success"), "should ignore case");
        }

        [Test]
        public void EncodeWithSpecialChars()
        {
            Assert.AreEqual("))((", EncodeText.DuplicateEncode("(( @"));
        }
    }
}