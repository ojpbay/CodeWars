using System.Linq;

namespace CodeWars
{
    public static class Fracts
    {
        public static string convertFrac(long[,] lst)
        {
            var fractionCount = lst.Length / 2;
            long[] denominators = new long[fractionCount];


            for (int i = 0; i < fractionCount; i++)
            {
                denominators[i] = lst[i, 1];
            }

            var lowestCommonMultiple = getLowestCommonMultiple(denominators);

            // write output below
            var output = "";

            for (int i = 0; i < fractionCount; i++)
            {
                var scaledNumerator = (lowestCommonMultiple / lst[i, 1]) * lst[i, 0];

                writeFraction(ref output, scaledNumerator, lowestCommonMultiple);
            }

            return output;
        }

        // see https://www.google.com/search?q=find+least+common+multiple&oq=find+least+common+multiple&aqs=edge..69i57j0i512l7j69i60.2607j0j4&sourceid=chrome&ie=UTF-8#kpvalbx=_aveqZNuvI-2W9u8P-aOo8Ak_41
        private static long getLowestCommonMultiple(long[] numbers, int iterationCount = 1)
        {
            var highest = findHighestNumberInArray(numbers) * iterationCount;

            foreach (var number in numbers)
            {
                if (highest % number != 0)
                {
                    iterationCount++;
                    return getLowestCommonMultiple(numbers, iterationCount);
                }
            }

            return highest;
        }

        private static long findHighestNumberInArray(long[] numbers)
        {
            return numbers.DefaultIfEmpty().Max();
        }

        private static void writeFraction(ref string output, long numerator, long denominator)
        {
            output += $"({numerator},{denominator})";
        }
    }
}
