using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    public class MultiplierTests
    {
        [Test]
        public void Multiply6And3_Returns18()
        {
            var result = Multiplier.Multiply(6, 3);
            Assert.That(result, Is.EqualTo(18));
        }

        [Test]
        public void Multiply3And9_Returns27()
        {
            var result = Multiplier.Multiply(3, 9);
            Assert.That(result, Is.EqualTo(27));
        }
    }
}