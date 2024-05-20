using System;
using NUnit.Framework;

namespace CodeWars
{
    [TestFixture]
    public class SumStringsAsNumbersTests
    {
        [Test]
        public void Given123And456Returns579()
        {
            var result = SumStringsAsNumbers.sumStrings("123", "456");
            Assert.That(result.Equals("579"));
        }

        [Test]
        public void Given131151201344081895336534324865And1Returns131151201344081895336534324866()
        {
            var result = SumStringsAsNumbers.sumStrings("131151201344081895336534324865", "1");
            Assert.That(result.Equals("131151201344081895336534324866"));
        }

        [Test]
        public void GivenAddingOneToLongMaxValue_ReturnsCorrectResult()
        {
            var result = SumStringsAsNumbers.sumStrings(long.MaxValue.ToString(), "1");
            Assert.That(result.Equals("9223372036854775808"));
        }
    }
}