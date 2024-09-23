using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CodeWars
{
    public static class DiagonalDifferenceResult
    {
        /*
     * Complete the 'diagonalDifference' function below.
     * https://www.hackerrank.com/challenges/one-month-preparation-kit-diagonal-difference/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-month-preparation-kit&playlist_slugs%5B%5D=one-month-week-one
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

        public static int diagonalDifference(List<List<int>> arr)
        {
            if (arr[0].Count != arr.Count)
                throw new ArgumentException("Matrix must be square");

            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;

            // get first diagonal - top left to bottom right
            for (int i = 0; i < arr.Count; i++)
            {
                firstDiagonalSum += arr[i][i];
                secondDiagonalSum += arr[i][arr[i].Count - i - 1];
            }

            return Math.Abs(firstDiagonalSum - secondDiagonalSum);
        }
    }

    [TestFixture]
    public class DiagonalDifferenceSolution
    {
        [Test]
        public void GivenSampleInput_Returns15()
        {
            /*
             *  3
                11 2 4
                4 5 6
                10 8 -12
            */

            var input = new List<List<int>> {
                new List<int> { 11, 2, 4 },
                new List<int> { 4, 5, 6 },
                new List<int> { 10, 8, -12 }
            };

            var result = DiagonalDifferenceResult.diagonalDifference(input);
            Assert.That(result, Is.EqualTo(15));
        }
    }
}
