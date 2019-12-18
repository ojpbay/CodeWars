using NUnit.Framework;

namespace CodeWars
{
    public class MultiplierTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestFixture]
        public class Tests
        {
            [Test]
            public void Multiply1()
            {
                Assert.AreEqual(18, Multiplier.Multiply(6, 3));
            }
        }
    }
}