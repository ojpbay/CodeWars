using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class PangramResult
    {
        /*
         * Complete the 'pangrams' function below.
         *
         * https://www.hackerrank.com/challenges/one-month-preparation-kit-pangrams/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-month-preparation-kit&playlist_slugs%5B%5D=one-month-week-one
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string pangrams(string s)
        {
            var result = new HashSet<string>();
            foreach (var letter in s.ToLowerInvariant().Where(x => x != ' '))
            {
                if (char.IsLetter(letter))
                    result.Add(letter.ToString());
            }

            return result.Count() == 26 ? "pangram" : "not pangram";
        }

    }

    [TestFixture]
    public class PangramSolution
    {
        [Test]
        public void NotPangram()
        {
            var input = "We promptly judged antique ivory buckles for the prize";
            var expected = "not pangram";

            var result = PangramResult.pangrams(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Pangram()
        {
            var input = "We promptly judged antique ivory buckles for the next prize";
            var expected = "pangram";

            var result = PangramResult.pangrams(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
