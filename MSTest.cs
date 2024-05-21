using NUnit.Framework;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    public class Solution
    {
        public int solution(string S)
        {
            var number = ConvertToBigInt(S);
            var iterations = 0;

            while (number != 0)
            {
                if (IsOdd(number))
                {
                    number -= 1;
                }
                else
                {
                    number = number / 2;
                }

                iterations++;
            }

            return iterations;
        }

        public static BigInteger ConvertToBigInt(string s)
        {
            return s.Aggregate(BigInteger.Zero, (acc, c) => acc * 2 + (c == '1' ? 1 : 0));
        }

        public static bool IsOdd(BigInteger number)
        {
            return number % 2 != 0;
        }
    }

    [TestFixture]
    public class MSTest
    {
        [Test]
        public void ConvertToBigInt_Binary11_ReturnsDecimal3()
        {
            var s = "11";
            var result = Solution.ConvertToBigInt(s);

            Assert.That(result == 3);
        }

        [Test]
        public void ConvertToBigInt_Binary10_ReturnsDecimal2()
        {
            var s = "10";
            var result = Solution.ConvertToBigInt(s);

            Assert.That(result == 2);
        }

        [Test]
        public void ConvertToBigInt_Binary1000001111_ReturnsDecimal527()
        {
            var s = "1000001111";
            var result = Solution.ConvertToBigInt(s);

            Assert.That(result == 527);
        }

        [Test]
        public void ConvertToBigInt_Binary011100_ReturnsDecimal28()
        {
            var s = "011100";
            var result = Solution.ConvertToBigInt(s);

            Assert.That(result == 28);
        }

        [Test]
        public void GivenBinaryString1_Returns1InvocationToReach0()
        {
            var s = "1";
            var sol = new Solution();
            var result = sol.solution(s);

            Assert.That(result == 1);
        }

        [Test]
        public void GivenBinaryString011100_Returns7InvocationsToReach0()
        {
            var s = "011100";
            var sol = new Solution();
            var result = sol.solution(s);

            Assert.That(result == 7);
        }

        [Test]
        public void GivenBinaryString111_Returns5InvocationsToReach0()
        {
            var s = "111";
            var sol = new Solution();
            var result = sol.solution(s);

            Assert.That(result == 5);

        }

        [Test]
        public void GivenBinaryString1111010101111_Returns22InvocationsToReach0()
        {
            var s = "1111010101111";

            var sol = new Solution();
            var result = sol.solution(s);

            Assert.That(result == 22);
        }

        [Test]
        public void GivenHugeBinaryString_ReturnsBigIntegerValue()
        {
            // append 1 to 400000 times
            var s = new string('1', 400000);

            var sol = new Solution();
            var result = sol.solution(s);

            Assert.That(result == 799999);
        }
    }
}
