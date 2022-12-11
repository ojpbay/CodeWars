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
            Assert.AreEqual("579", SumStringsAsNumbers.sumStrings("123", "456"));
        }

        [Test]
        public void Given131151201344081895336534324865And1Returns131151201344081895336534324866()
        {
            Assert.AreEqual("131151201344081895336534324866", SumStringsAsNumbers.sumStrings("131151201344081895336534324865", "1"));
        }
    }
}