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
            var count = CountingDuplicates.DuplicateCount("");
            Assert.That(count, Is.EqualTo(0));
        }

        [Test]
        public void CountingDuplicates2()
        {
            var count = CountingDuplicates.DuplicateCount("abcde");
            Assert.That(count, Is.EqualTo(0));
        }

        [Test]
        public void CountingDuplicates3()
        {
            var count = CountingDuplicates.DuplicateCount("aabbcde");
            Assert.That(count, Is.EqualTo(2));
        }

        [Test]
        public void CountingDuplicates4()
        {
            var count = CountingDuplicates.DuplicateCount("aabBcde");
            Assert.That(count, Is.EqualTo(2), "should ignore case");
        }

        [Test]
        public void CountingDuplicates5()
        {
            var count = CountingDuplicates.DuplicateCount("Indivisibility");
            Assert.That(count, Is.EqualTo(1));
        }

        [Test]
        public void CountingDuplicates6()
        {
            var count = CountingDuplicates.DuplicateCount("Indivisibilities");
            Assert.That(count, Is.EqualTo(2), "characters may not be adjacent");
        }
    }
}