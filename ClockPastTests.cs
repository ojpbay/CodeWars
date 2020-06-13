using NUnit.Framework;

namespace CodeWars
{
    public class ClockPastTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ClockPastTests1()
        {
            Assert.AreEqual(61000, ClockPast.CountAfterMidnight(0, 1, 1));
        }
    }
}