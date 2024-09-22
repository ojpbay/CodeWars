using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class MinMaxSumResult
    {


        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         * See https://www.hackerrank.com/challenges/one-month-preparation-kit-mini-max-sum/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-month-preparation-kit&playlist_slugs%5B%5D=one-month-week-one
         */

        public static string miniMaxSum(List<int> arr)
        {
            var min = arr.OrderBy(x => x).Select(x => (long)x).Take(4).Sum();
            var max = arr.OrderByDescending(x => x).Select(x => (long)x).Take(4).Sum();

            return $"{min} {max}";
        }

    }

    [TestFixture]
    public class MinMaxSumSolution
    {
        [Test]
        public void Test1()
        {
            int[] integers = [1, 2, 3, 4, 5];

            string result = MinMaxSumResult.miniMaxSum(integers.ToList());
            Assert.That(result, Is.EqualTo("10 14"));
        }

        [Test]
        public void Test2()
        {

            //2,147,483,647

            int[] integers = [1, 2, 3, 4, 2147483647];

            string result = MinMaxSumResult.miniMaxSum(integers.ToList());
            Assert.That(result, Is.EqualTo("10 2147483656"));
        }
    }
}
