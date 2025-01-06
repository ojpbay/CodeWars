using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    public static class DivisibleSumPairsResult
    {
        /*
         * Complete the 'divisibleSumPairs' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER k
         *  3. INTEGER_ARRAY ar
         */
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            var count = 0;

            // get pairs from ar that are divisible by k
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }

    [TestFixture]
    public class DivisibleSumPairsSolution
    {
        [Test]
        public void DivisorOf3_Returns5DivisiblePairs()
        {
            var k = 3;
            var ar = new List<int> { 1, 3, 2, 6, 1, 2 };

            var result = DivisibleSumPairsResult.divisibleSumPairs(ar.Count, k, ar);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void DivisorOf4_Returns2DivisiblePairs()
        {
            var k = 4;
            var ar = new List<int> { 1, 4, 6, 2, 3 };

            var result = DivisibleSumPairsResult.divisibleSumPairs(ar.Count, k, ar);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
