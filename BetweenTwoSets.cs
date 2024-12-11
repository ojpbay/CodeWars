using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class BetweenTwoSetsResult
    {
        /*
         * Complete the 'getTotalX' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */
        public static int getTotalX(List<int> a, List<int> b)
        {
            int total = 0;
            for (int x = 1; x <= 100; x++)
            {
                if (a.TrueForAll(i => x % i == 0) && b.TrueForAll(i => i % x == 0))
                {
                    total++;
                }
            }

            return total;
        }
    }

    [TestFixture]
    public class BetweenTwoSetsSolution
    {
        [Test]
        public void Test1()
        {
            var a = new List<int>() { 2, 4 };
            var b = new List<int>() { 16, 32, 96 };

            var result = BetweenTwoSetsResult.getTotalX(a, b);

            Assert.That(result, Is.EqualTo(3));
        }
    }
}
