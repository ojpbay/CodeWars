using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    public static class GenerateRangeTests
    {
        [Test]
        [TestCase(2, 10, 2, ExpectedResult = new int[] { 2, 4, 6, 8, 10 })]
        public static int[] FixedTest(int min, int max, int step)
        {
            return RangeGenerator.GenerateRange(min, max, step);
        }

    }
}