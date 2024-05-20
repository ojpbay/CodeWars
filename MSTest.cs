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

        public BigInteger ConvertToBigInt(string s)
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
        public void TestToBigInt1()
        {
            var s = "1000001111";
            var sol = new Solution();
            var result = sol.ConvertToBigInt(s);

            Assert.That(result == 527);
        }

        [Test]
        public void TestToBigInt2()
        {
            var s = "011100";
            var sol = new Solution();
            var result = sol.ConvertToBigInt(s);

            Assert.That(result == 28);
        }

        [Test]
        public void TestToBigInt3()
        {
            var s = "11";
            var sol = new Solution();
            var result = sol.ConvertToBigInt(s);

            Assert.That(result == 3);
        }

        [Test]
        public void TestToBigInt4()
        {
            var s = "10";
            var sol = new Solution();
            var result = sol.ConvertToBigInt(s);

            Assert.That(result == 2);
        }

        [Test]
        public void Test0()
        {
            var s = "1";
            var sol = new Solution();
            var result = sol.solution(s);

            Assert.That(result == 1);
        }

        [Test]
        public void Test1()
        {
            var s = "011100";
            var sol = new Solution();
            var result = sol.solution(s);

            Assert.That(result == 7);
        }

        [Test]
        public void Test2()
        {
            var s = "111";
            var sol = new Solution();
            var result = sol.solution(s);

            Assert.That(result == 5);

        }

        [Test]
        public void Test3()
        {
            var s = "1111010101111";

            var sol = new Solution();
            var result = sol.solution(s);

            Assert.That(result == 22);
        }

        [Test]
        public void Test4()
        {
            // append 1 to 400000 times
            var s = new string('1', 400000);

            var sol = new Solution();
            var result = sol.solution(s);

            Assert.That(result == 799999);
        }
    }
}
