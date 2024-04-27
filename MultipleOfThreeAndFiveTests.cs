using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    public static class MultipleOfThreeAndFiveTests
    {
        [Test]
        public static void MultipleOfThreeAndFiveBelow23_Returns10()
        {
            Assert.AreEqual(23, MultipleOfThreeAndFive.Solution(10));
        }
    }
}