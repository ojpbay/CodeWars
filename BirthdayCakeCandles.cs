using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class BirthdayCakeCandlesResult
    {
        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int BirthdayCakeCandles(List<int> candles)
        {
            var highest = candles.Max();
            return candles.Where(x => x == highest).Count();
        }

    }

    [TestFixture]
    public class BirthdayCakeCandlesSolution
    {
        [Test]
        public void CountOfTallest_3Tallest_Returns2()
        {
            List<int> candles = new List<int>() { 3, 2, 1, 3 };

            var result = BirthdayCakeCandlesResult.BirthdayCakeCandles(candles);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
