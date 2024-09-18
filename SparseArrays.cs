using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class SparseArrayResult
    {


        /*
         *  Complete the 'matchingStrings' function below.
         *  
         *  * https://www.hackerrank.com/challenges/one-month-preparation-kit-sparse-arrays/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-month-preparation-kit&playlist_slugs%5B%5D=one-month-week-one
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY strings
         *  2. STRING_ARRAY queries
         */

        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            var result = new List<int>();

            foreach (var query in queries)
            {
                int counter = 0;

                foreach (var str in strings)
                {
                    if (query == str)
                    {
                        counter++;
                    }
                }

                result.Add(counter);
            }

            return result;
        }

    }

    [TestFixture]
    public class SparseArraySolution
    {
        [Test]
        public void Test1()
        {
            string[] strings = ["ab", "ab", "abc"];
            string[] queries = ["ab", "abc", "bc"];

            int[] expected = [2, 1, 0];

            var result = SparseArrayResult.matchingStrings(strings.ToList(), queries.ToList());
            Assert.That(result, Is.EqualTo(expected.ToList()));
        }
    }
}
