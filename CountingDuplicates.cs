using NUnit.Framework;
using System.Linq;

namespace CodeWars
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            var test = str.ToLower().Select(c => str.Count(inner => inner.ToString().ToLower() == c.ToString().ToLower()) > 1 ? c : 0).Distinct().ToArray();
            return test.Where(x => x > 1).ToArray().Length;
        }
    }
}