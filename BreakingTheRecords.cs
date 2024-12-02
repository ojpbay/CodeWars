﻿using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWars
{
    public static class BreakTheRecordsResult
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            int min = scores[0], max = scores[0], minBrokenCount = 0, maxBrokenCount = 0;

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] < min) { min = scores[i]; minBrokenCount++; }
                else if (scores[i] > max) { max = scores[i]; maxBrokenCount++; }
            }

            return [maxBrokenCount, minBrokenCount];
        }
    }



    [TestFixture]
    public class BreakTheRecordsSolution
    {
        [Test]
        public void HighestScoreBroken2TimesAndLowestScoreBroken4Times()
        {
            List<int> scores = [10, 5, 20, 20, 4, 5, 2, 25, 1];

            var result = BreakTheRecordsResult.breakingRecords(scores);
            Assert.That(result[0], Is.EqualTo(2));
            Assert.That(result[1], Is.EqualTo(4));
        }

        [Test]
        public void HighestScoreBroken4TimesAndLowestScoreBrokenZeroTimes()
        {
            List<int> scores = [3, 4, 21, 36, 10, 28, 35, 5, 24, 42];

            var result = BreakTheRecordsResult.breakingRecords(scores);
            Assert.That(result[0], Is.EqualTo(4));
            Assert.That(result[1], Is.EqualTo(0));
        }
    }
}
