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
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

        public static string pangrams(string s)
        {
            var alpha = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            foreach (var letter in s.ToLowerInvariant().ToCharArray().Where(x => x != ' '))
            {
                if (alpha.Contains(letter.ToString()))
                {
                    alpha.Remove(letter.ToString());
                }
            }

            return alpha.Count() > 0 ? "not pangram" : "pangram";
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
