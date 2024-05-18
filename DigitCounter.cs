using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class DigitCounter
    {
        public static int SumDigits(int number)
        {
            var intList = Math.Abs(number).ToString().Select(digit => int.Parse(digit.ToString()));
            return intList.Sum();
        }
    }

    public class DigitCounterTests
    {
#pragma warning disable S1144 // Unused private types or members should be removed
        private static IEnumerable<TestCaseData> testCases
#pragma warning restore S1144 // Unused private types or members should be removed
        {
            get
            {
                yield return new TestCaseData(10).Returns(1);
                yield return new TestCaseData(99).Returns(18);
                yield return new TestCaseData(-32).Returns(5);
            }
        }

        [Test, TestCaseSource("testCases")]
        public int FixedTest(int number) => DigitCounter.SumDigits(number);
    }
}
