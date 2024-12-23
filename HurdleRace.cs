using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class HurdleRaceResult
    {
        /*
         * Complete the 'hurdleRace' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY height
         */

        public static int hurdleRace(int k, List<int> height)
        {
            var highest = height.Max();

            return highest <= k ? 0 : highest - k;
        }
    }

    [TestFixture]
    public class HurdleRaceSolution
    {
        [Test]
        public void TwoPotionsNeeded()
        {
            var result = HurdleRaceResult.hurdleRace(4, new List<int> { 1, 6, 3, 5, 2 });

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void NoPotionsNeeded()
        {
            var result = HurdleRaceResult.hurdleRace(7, new List<int> { 2, 5, 4, 5, 2 });

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void ThreePotionsNeeded()
        {
            var result = HurdleRaceResult.hurdleRace(4, new List<int> { 1, 6, 3, 5, 7 });

            Assert.That(result, Is.EqualTo(3));
        }
    }
}
