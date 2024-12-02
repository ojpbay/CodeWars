using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class BreakTheRecordsResult
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            int min = scores[0];
            int max = scores[0];

            int minBrokenCount = 0;
            int maxBrokenCount = 0;

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] < min)
                {
                    min = scores[i];
                    minBrokenCount++;
                }

                if (scores[i] > max)
                {
                    max = scores[i];
                    maxBrokenCount++;
                }
            }

            return new List<int>() { maxBrokenCount, minBrokenCount };
        }
    }



    [TestFixture]
    public class BreakTheRecordsSolution
    {
        [Test]
        public void Test1()
        {
            int[] integers = { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            var result = BreakTheRecordsResult.breakingRecords(integers.ToList());
            Assert.That(result[0], Is.EqualTo(2)); // number of times highest score was broken
            Assert.That(result[1], Is.EqualTo(4)); // number of times lowest score was broken
        }

        [Test]
        public void Test2()
        {
            int[] integers = { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            var result = BreakTheRecordsResult.breakingRecords(integers.ToList());
            Assert.That(result[0], Is.EqualTo(4));
            Assert.That(result[1], Is.EqualTo(0));
        }
    }
}
