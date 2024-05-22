using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class RgbToHexConverterTests
    {
        [Test]
        public void ConvertToHex_255_255_255_Returns_FFFFFF()
        {
            var result = RgbToHexConverter.Rgb(255, 255, 255);
            Assert.That(result, Is.EqualTo("FFFFFF"));
        }

        [Test]
        public void ConvertToHex_HexValueOver255_UsesMaxValueOf255()
        {
            var result = RgbToHexConverter.Rgb(255, 255, 300);
            Assert.That(result, Is.EqualTo("FFFFFF"));
        }

        [Test]
        public void ConvertToHex_0_0_0_Returns_000000()
        {
            var result = RgbToHexConverter.Rgb(0, 0, 0);
            Assert.That(result, Is.EqualTo("000000"));
        }

        [Test]
        public void ConvertToHex_148_0_211_Returns9400D3()
        {
            var result = RgbToHexConverter.Rgb(148, 0, 211);
            Assert.That(result, Is.EqualTo("9400D3"));
        }

        [Test]
        public void ConvertToHex_NegativeHexNumberTreatedAsZero()
        {
            var result = RgbToHexConverter.Rgb(148, -20, 211);
            Assert.That(result, Is.EqualTo("9400D3"), "Handles negative numbers");
        }

        [Test]
        public void ConvertToHex_144_195_212_Returns_90C3D4()
        {
            var result = RgbToHexConverter.Rgb(144, 195, 212);
            Assert.That(result, Is.EqualTo("90C3D4"));
        }

        [Test]
        public void ConvertToHex_212_53_2_Returns_D43502()
        {
            var result = RgbToHexConverter.Rgb(212, 53, 2);
            Assert.That(result, Is.EqualTo("D43502"), "Consider single hex digit numbers");
        }
    }
}
