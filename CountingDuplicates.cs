using NUnit.Framework;
using System.Linq;

namespace CodeWars
{
    public static class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            var test = str.ToLower().Select(c => str.Count(inner => inner.ToString().ToLower() == c.ToString().ToLower()) > 1 ? c : 0).Distinct().ToArray();
            return test.Where(x => x > 1).ToArray().Length;
        }
    }

    public class CountingDuplicatesTests
    {
        [Test]
        public void CountingDuplicates1()
        {
            Assert.AreEqual(0, CountingDuplicates.DuplicateCount(""));
        }

        [Test]
        public void CountingDuplicates2()
        {
            Assert.AreEqual(0, CountingDuplicates.DuplicateCount("abcde"));
        }

        [Test]
        public void CountingDuplicates3()
        {
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabbcde"));
        }

        [Test]
        public void CountingDuplicates4()
        {
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabBcde"), "should ignore case");
        }

        [Test]
        public void CountingDuplicates5()
        {
            Assert.AreEqual(1, CountingDuplicates.DuplicateCount("Indivisibility"));
        }

        [Test]
        public void CountingDuplicates6()
        {
            Assert.AreEqual(2, CountingDuplicates.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}