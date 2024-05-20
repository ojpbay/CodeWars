using NUnit.Framework;

namespace CodeWars
{
    public class EncodeTextTests
    {
        [Test]
        public void SimpleEncode()
        {
            var encoded = EncodeText.DuplicateEncode("din");
            Assert.That(encoded.Equals("((("));
        }

        [Test]
        public void EncodeWithDuplicates()
        {
            var encoded = EncodeText.DuplicateEncode("recede");
            Assert.That(encoded.Equals("()()()"));
        }

        [Test]
        public void EncodeWithMixedCasing()
        {
            var encoded = EncodeText.DuplicateEncode("DinG");
            Assert.That(encoded.Equals("(((("));
        }

        [Test]
        public void EncodeWithSpecialChars()
        {
            var encoded = EncodeText.DuplicateEncode("din%sg^");
            Assert.That(encoded.Equals("((((((("));
        }
    }
}