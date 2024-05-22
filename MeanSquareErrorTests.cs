using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    public class MeanSquareErrorTests
    {
        [Test]
        public void ArraysWhereMeanSquaredDifferenceIsAnIntegerValue_ReturnsCorrectResult()
        {
            // arrange
            var first = new int[] { 1, 2, 3 };
            var second = new int[] { 4, 5, 6 };

            // act
            var result = MeanSquareError.Solution(first, second);

            // assert
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void ArraysWhereMeanSquaredDifferenceIsNotAnIntegerValue_ReturnsCorrectResult()
        {
            // arrange
            var first = new int[] { 10, 20, 10, 2 };
            var second = new int[] { 10, 25, 5, -2 };

            // act
            var result = MeanSquareError.Solution(first, second);

            // assert
            Assert.That(result, Is.EqualTo(16.5));
        }

        [Test]
        public void ArraysWithNegativeNumbers_ReturnsCorrectResult()
        {
            // arrange
            var first = new int[] { 0, -1 };
            var second = new int[] { -1, 0 };

            // act
            var result = MeanSquareError.Solution(first, second);

            // assert
            Assert.That(result, Is.EqualTo(1));
        }
    }
}