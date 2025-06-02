using NUnit.Framework;
using System;
using System.Numerics;

namespace CodeWars
{
    [TestFixture]
    public class TestDomeTests
    {

        public static string RemoveDuplicateCharactersFromString(string str)
        {
            string result = string.Empty;

            for (int i = 0; i <= str.Length - 1; i++)
            {
                if (result.IndexOf(str[i]) < 0)
                {
                    result += str[i];
                }
            }
            return result;
        }

        [Test]
        public void RemoveDuplicateCharactersFromString_GivenAABBCCDDEReturnsABCDE()
        {
            var result = RemoveDuplicateCharactersFromString("AABBCCDDE");
            Assert.That(result, Is.EqualTo("ABCDE"));
        }
    }
}