using NUnit.Framework;
using System.Linq;
using System.Numerics;

namespace CodeWars
{
    public class Solution
    {
        public int solution(string S)
        {
            //var number = Convert.ToInt64(S, 2);
            //var number = BigInteger.Parse(S, System.Globalization.NumberStyles.AllowHexSpecifier);
            var number = ConvertToBigInt(S);

            //var number = new BigInteger(28);

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
    public class Test
    {
        [Test]
        public void TestToBigInt1()
        {
            var s = "1000001111";
            var sol = new Solution();
            var result = sol.ConvertToBigInt(s);

            Assert.True(527 == result);
        }

        [Test]
        public void TestToBigInt2()
        {
            var s = "011100";
            var sol = new Solution();
            var result = sol.ConvertToBigInt(s);

            Assert.True(28 == result);
        }

        [Test]
        public void TestToBigInt3()
        {
            var s = "11";
            var sol = new Solution();
            var result = sol.ConvertToBigInt(s);

            Assert.True(3 == result);
        }

        [Test]
        public void TestToBigInt4()
        {
            var s = "10";
            var sol = new Solution();
            var result = sol.ConvertToBigInt(s);

            Assert.True(2 == result);
        }

        [Test]
        public void Test0()
        {
            var s = "1";
            var sol = new Solution();
            var result = sol.solution(s);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test1()
        {
            var s = "011100";
            var sol = new Solution();
            var result = sol.solution(s);

            Assert.AreEqual(7, result);
        }

        [Test]
        public void Test2()
        {
            var s = "111";
            var sol = new Solution();
            var result = sol.solution(s);

            Assert.AreEqual(5, result);

        }

        [Test]
        public void Test3()
        {
            var s = "1111010101111";

            var sol = new Solution();
            var result = sol.solution(s);

            Assert.AreEqual(22, result);
        }

        [Test]
        public void Test4()
        {
            // append 1 to 400000 times
            var s = new string('1', 400000);

            var sol = new Solution();
            var result = sol.solution(s);

            Assert.AreEqual(799999, result);
        }
    }
}
