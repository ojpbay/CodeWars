﻿using NUnit.Framework;

namespace CodeWars
{

    [TestFixture]
    public class FractsTests
    {

        [Test]
        public void Test1()
        {
            // arrange
            long[,] lst = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };

            // act
            var result = Fracts.convertFrac(lst);

            // assert
            Assert.That(result.Equals("(6,12)(4,12)(3,12)"));
        }
    }

}