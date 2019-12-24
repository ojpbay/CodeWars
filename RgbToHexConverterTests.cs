using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class RgbToHexConverterTests
    {
        [Test]
        public void ConvertToHex1()
        {
            Assert.AreEqual("FFFFFF", RgbToHexConverter.Rgb(255, 255, 255));
        }

        [Test]
        public void ConvertToHex2()
        {
            Assert.AreEqual("FFFFFF", RgbToHexConverter.Rgb(255, 255, 300));
        }

        [Test]
        public void ConvertToHex3()
        {
            Assert.AreEqual("000000", RgbToHexConverter.Rgb(0, 0, 0));
        }

        [Test]
        public void ConvertToHex4()
        {
            Assert.AreEqual("9400D3", RgbToHexConverter.Rgb(148, 0, 211));
        }

        [Test]
        public void ConvertToHex5()
        {
            Assert.AreEqual("9400D3", RgbToHexConverter.Rgb(148, -20, 211), "Handle negative numbers.");
        }

        [Test]
        public void ConvertToHex6()
        {
            Assert.AreEqual("90C3D4", RgbToHexConverter.Rgb(144, 195, 212));
        }

        [Test]
        public void ConvertToHex7()
        {
            Assert.AreEqual("D4350C", RgbToHexConverter.Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }
    }
}
