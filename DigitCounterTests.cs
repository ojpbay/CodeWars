using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWars
{
    public class DigitCounterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        private static IEnumerable<TestCaseData> testCases
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