using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class ApplesAndOrangesResult
    {
        /*
         * Complete the 'countApplesAndOranges' function below.
         *
         * The function accepts following parameters:
         *  1. INTEGER s (start of house)
         *  2. INTEGER t (end of house)
         *  3. INTEGER a (apple tree)
         *  4. INTEGER b (orange tree)
         *  5. INTEGER_ARRAY apples
         *  6. INTEGER_ARRAY oranges
         *  https://s3.amazonaws.com/hr-challenge-images/25220/1474218925-f2a791d52c-Appleandorange2.png
         *  https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true
         */

        public static Tuple<int, int> countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            var appleResult = new List<int>();
            var orangeResult = new List<int>();

            foreach (var apple in apples)
            {
                appleResult.Add(a + apple);
            }

            foreach (var orange in oranges)
            {
                orangeResult.Add(b + orange);
            }

            // apples in range
            var applesOnHouse = appleResult.Where(a => a >= s && a <= t);
            var orangesOnHouse = orangeResult.Where(o => o <= t && o >= s);

            return new Tuple<int, int>(applesOnHouse.Count(), orangesOnHouse.Count());
        }
    }

    [TestFixture]
    public class ApplesAndOrangesSolution
    {
        [Test]
        public void Test1()
        {
            var result = ApplesAndOrangesResult.countApplesAndOranges(7, 11, 5, 15, new List<int> { -2, 2, 1 }, new List<int> { 5, -6 });
            Assert.That(result, Is.EqualTo(new Tuple<int, int>(1, 1)));
        }
    }
}
