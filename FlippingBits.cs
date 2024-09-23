using NUnit.Framework;
using System;
using System.Linq;

namespace CodeWars
{
    public static class FlippingBitsResult
    {
        /*
        * Complete the 'flippingBits' function below.
        *
        * The function is expected to return a LONG_INTEGER.
        * The function accepts LONG_INTEGER n as parameter.
        */

        public static long flippingBits(long n)
        {
            var binary = Convert.ToString(n, 2).PadLeft(32, '0');
            var t = binary.ToString().Select(x => x == '0' ? "1" : "0").Aggregate("", (current, bit) => current + bit);
            return Convert.ToInt64(t, 2);
        }
    }

    [TestFixture]
    public class FlippingBitsSolution
    {
        [Test]
        public void Given1_Returns4294967294()
        {
            var result = FlippingBitsResult.flippingBits(1);
            Assert.That(result, Is.EqualTo(4294967294));
        }
    }
}
