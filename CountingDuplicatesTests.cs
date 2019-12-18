using NUnit.Framework;

namespace CodeWars
{
    public class CountingDuplicatesTests
    {
        [SetUp]
        public void Setup()
        {
        }

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