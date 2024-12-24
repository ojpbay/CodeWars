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
         *  1. INTEGER k - the number of students required to be present to avoid class cancellation
         *  2. INTEGER_ARRAY a - the arrival times of the students (negative values indicate the student arrived early)
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
        public void ThreeStudentsRequired_ThreeStudentsArriveOnTime_ClassIsNotCancelled()
        {
            var k = 3;
            var a = new List<int> { -2, -1, 0, 1, 2 };
            var expected = "NO";

            var result = AngryProfessorResult.AngryProfessor(k, a);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TwoStudentsRequired_ThreeStudentsArriveOnTime_ClassIsNotCancelled()
        {
            var k = 2;
            var a = new List<int> { -2, -1, 0, 1, 2 };
            var expected = "NO";

            var result = AngryProfessorResult.AngryProfessor(k, a);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void FiveStudentsRequired_FourStudentsArriveOnTime_ClassIsCancelled()
        {
            var k = 5;
            var a = new List<int> { -2, -1, 0, 0, 2, 3 };
            var expected = "YES";

            var result = AngryProfessorResult.AngryProfessor(k, a);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
