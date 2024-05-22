using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    public static class MultipleOfThreeAndFiveTests
    {
        [Test]
        public static void MultipleOfThreeAndFiveBelow23_Returns10()
        {
            var result = MultipleOfThreeAndFive.Solution(10);
            Assert.That(result, Is.EqualTo(23));
        }
    }
}