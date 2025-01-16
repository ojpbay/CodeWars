using NUnit.Framework;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeWars
{
    public static class TheBirthdayBarResult
    {
        /*
         * Complete the 'birthday' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY s
         *  2. INTEGER d
         *  3. INTEGER m
         */
        public static int birthday(List<int> s, int d, int m)
        {
            int total = 0;

            for (int i = 0; i < s.Count; i++)
            {
                try
                {
                    var piece = s.Slice(i, m);
                    if (piece.Sum() == d)
                    {
                        total++;
                    }
                }
                catch (ArgumentException)
                {
                    break;
                }
            }

            return total;
        }
    }

    [TestFixture]
    public class TheBirthdayBaSolution
    {
        [Test]
        public void Sum3_Length2_Returns2Possibilities()
        {
            List<int> bar = [1, 2, 1, 3, 2];

            var result = TheBirthdayBarResult.birthday(bar, 3, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Sum3_Length2_Returns0Possibilities()
        {
            List<int> bar = [1, 1, 1, 1, 1, 1];

            var result = TheBirthdayBarResult.birthday(bar, 3, 2);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Sum4_Length1_Returns1Possibility()
        {
            List<int> bar = [4, 1];

            var result = TheBirthdayBarResult.birthday(bar, 4, 1);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Sum4_Length1_MatchAtEnd_Returns1Possibility()
        {
            List<int> bar = [1, 4];

            var result = TheBirthdayBarResult.birthday(bar, 4, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
