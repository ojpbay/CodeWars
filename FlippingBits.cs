using NUnit.Framework;
using System;
using System.Text;

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
            var binary = Convert.ToString(n, 2);

            while (binary.Length < 32)
            {
                binary = "0" + binary;
            }

            var sb = new StringBuilder();

            foreach (var bit in binary.ToCharArray())
            {
                if (bit == '0')
                {
                    sb.Append("1");
                }
                else
                {
                    sb.Append("0");
                }
            }

            return Convert.ToInt64(sb.ToString(), 2);
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
