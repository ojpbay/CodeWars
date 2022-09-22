using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    public class MultipleOfThreeAndFiveTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MultipleOfThreeAndFiveBelow23_Returns10()
        {
            Assert.AreEqual(23, MultipleOfThreeAndFive.Solution(10));
        }
    }
}