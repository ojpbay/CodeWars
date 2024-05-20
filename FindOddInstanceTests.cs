using NUnit.Framework;

namespace CodeWars
{
    public class FindOddInstanceTests
    {
        [Test]
        public void SequenceWith3InstancesOf5_Returns5()
        {
            // arrange
            var sequence = new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };

            // act
            var result = FindOddInstance.FindIt(sequence);

            // assert
            Assert.That(result.Equals(5));
        }
    }
}