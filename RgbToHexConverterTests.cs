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
            var result = RgbToHexConverter.Rgb(255, 255, 255);
            Assert.That(result.Equals("FFFFFF"));
        }

        [Test]
        public void ConvertToHex2()
        {
            var result = RgbToHexConverter.Rgb(255, 255, 300);
            Assert.That(result.Equals("FFFFFF"));
        }

        [Test]
        public void ConvertToHex3()
        {
            var result = RgbToHexConverter.Rgb(0, 0, 0);
            Assert.That(result.Equals("000000"));
        }

        [Test]
        public void ConvertToHex4()
        {
            var result = RgbToHexConverter.Rgb(148, 0, 211);
            Assert.That(result.Equals("9400D3"));
        }

        [Test]
        public void ConvertToHex5()
        {
            var result = RgbToHexConverter.Rgb(148, -20, 211);
            Assert.That(result.Equals("9400D3"), "Handles negative numbers");
        }

        [Test]
        public void ConvertToHex6()
        {
            var result = RgbToHexConverter.Rgb(144, 195, 212);
            Assert.That(result.Equals("90C3D4"));
        }

        [Test]
        public void ConvertToHex7()
        {
            var result = RgbToHexConverter.Rgb(212, 53, 2);
            Assert.That(result.Equals("D43502"), "Consider single hex digit numbers");
        }
    }
}
