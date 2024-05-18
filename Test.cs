using NUnit.Framework;
using System;

namespace CodeWars
{
    public class Solution
    {
        public int solution(string S)
        {
            var number = Convert.ToInt64(S, 2);
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

        public static bool IsOdd(Int64 number)
        {
            return number % 2 != 0;
        }
    }

    [TestFixture]
    public class Test
    {
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
