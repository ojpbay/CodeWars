using System;
using System.Linq;

namespace CodeWars
{
    public static class MeanSquareError
    {
        public static double Solution(int[] firstArray, int[] secondArray)
        {
            var arrayLength = firstArray.Length;
            var resultArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                var firstArrayValue = firstArray[i];
                var secondArrayValue = secondArray[i];
                var difference = firstArrayValue - secondArrayValue;

                // add the square of the difference to the result array
                resultArray[i] = (int)Math.Pow(difference, 2);
            }

            var arrayMean = (double)resultArray.Sum() / arrayLength;
            return arrayMean;
        }
    }
}
