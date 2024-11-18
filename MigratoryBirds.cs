using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class MigratoryBirdsResult
    {

        /*
         * Complete the 'migratoryBirds' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static int migratoryBirds(List<int> arr)
        {
            return arr.GroupBy(x => x)
                    .OrderByDescending(x => x.Count())
                    .ThenBy(x => x.Key)
                    .First()
                    .Key;
        }

        [TestFixture]
        public class MigratoryBirdsSolution
        {
            [Test]
            public void Given11223_Returns1()
            {
                var result = MigratoryBirdsResult.migratoryBirds(new List<int> { 1, 1, 2, 2, 3 });
                Assert.That(result, Is.EqualTo(1));
            }


            [Test]
            public void Given_12345432134Returns3()
            {
                var result = MigratoryBirdsResult.migratoryBirds(new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 });
                Assert.That(result, Is.EqualTo(3));
            }
        }
    }
}
