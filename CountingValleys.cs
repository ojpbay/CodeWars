using NUnit.Framework;

namespace CodeWars
{
    public static class CountingValleysResult
    {
        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(int steps, string path)
        {
            int currentDepth = 0;
            int minDepth = 0;
            int valleyCount = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path.Substring(i, 1).ToLowerInvariant() == "d")
                {
                    currentDepth--;
                }
                else
                {
                    currentDepth++;
                }

                if (currentDepth < minDepth)
                {
                    minDepth = currentDepth;
                }

                if (currentDepth == 0 && minDepth < 0)
                {
                    valleyCount++;
                    minDepth = currentDepth;
                }
            }

            return valleyCount;
        }
    }



    [TestFixture]
    public class CountingValleysSolution
    {
        [Test]
        public void TestOfSingleValley()
        {
            var path = "UDDDUDUU";

            var result = CountingValleysResult.countingValleys(path.Length, path);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void TestOfTwoValleys()
        {
            var path = "DDUUDDUU";

            var result = CountingValleysResult.countingValleys(path.Length, path);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void TestOfZeroValleys()
        {
            var path = "UUUUDDDD";

            var result = CountingValleysResult.countingValleys(path.Length, path);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
