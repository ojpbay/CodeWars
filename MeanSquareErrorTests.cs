using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    public class MeanSquareErrorTests
    {
        [Test, Description("Sample Tests 1")]
        public void SampleTest1()
        {
            Assert.AreEqual(9, MeanSquareError.Solution(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
        }

        [Test, Description("Sample Tests 2")]
        public void SampleTest2()
        {
            Assert.AreEqual(16.5, MeanSquareError.Solution(new int[] { 10, 20, 10, 2 }, new int[] { 10, 25, 5, -2 }));
        }

        [Test, Description("Sample Tests 3")]
        public void SampleTest3()
        {
            Assert.AreEqual(1, MeanSquareError.Solution(new int[] { 0, -1 }, new int[] { -1, 0 }));
        }
    }
}