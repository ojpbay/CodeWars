using NUnit.Framework;

namespace CodeWars
{
    public class FindOddInstanceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(5, FindOddInstance.FindIt(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }
}