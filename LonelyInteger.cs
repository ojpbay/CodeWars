using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class LonelyIntegerResult
    {


        /*
         * Complete the 'lonelyinteger' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         * 
         * See https://www.hackerrank.com/challenges/one-month-preparation-kit-lonely-integer/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-month-preparation-kit&playlist_slugs%5B%5D=one-month-week-one
         * 
         */

        public static int lonelyinteger(List<int> integers)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int i in integers)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }

            return dict.FirstOrDefault(x => x.Value == 1).Key;
        }

    }

    [TestFixture]
    public class LonelyIntegerSolution
    {
        [Test]
        public void Test1()
        {
            int[] integers = [1, 2, 3, 4, 3, 2, 1];

            var result = LonelyIntegerResult.lonelyinteger(integers.ToList());
            Assert.That(result, Is.EqualTo(4));
        }
    }
}
