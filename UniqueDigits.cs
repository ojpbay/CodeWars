using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class UniqueDigits
    {
        public static class Kata
        {
            public static int GetUnique(IEnumerable<int> numbers)
            {
                var mirror = new List<int>();
                mirror.AddRange(numbers);

                var hashSet = new HashSet<int>();

                foreach (var num in numbers)
                {
                    bool success = hashSet.Add(num);
                    if (!success)
                    {
                        mirror.RemoveAll(d => d == num);
                    }
                }

                return mirror.FirstOrDefault();
            }
        }

        [TestFixture]
        public class UniqueDigitsTest
        {
            [TestCase(new[] { 1, 2, 2, 2 }, ExpectedResult = 1)]
            [TestCase(new[] { -2, 2, 2, 2 }, ExpectedResult = -2)]
            [TestCase(new[] { 11, 11, 14, 11, 11 }, ExpectedResult = 14)]
            [TestCase(new[] { 8, 8, 8, 8, 7 }, ExpectedResult = 7)]
            public int BaseTest(IEnumerable<int> numbers)
            {
                return Kata.GetUnique(numbers);
            }
        }
    }
}
