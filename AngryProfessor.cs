using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class AngryProfessorResult
    {
        /*
         * Complete the 'angryProfessor' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY a
         */

        public static string AngryProfessor(int k, List<int> a)
        {
            return a.Where(x => x <= 0).Count() >= k ? "NO" : "YES";
        }
    }

    [TestFixture]
    public class AngryProfessorSolution
    {
        [Test]
        public void ThreeStudentsRequired_EnoughStudentsArriveOnTime_ClassIsNotCancelled()
        {
            var k = 3;
            var a = new List<int> { -2, -1, 0, 1, 2 };
            var expected = "NO";

            var result = AngryProfessorResult.AngryProfessor(k, a);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
