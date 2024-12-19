using NUnit.Framework;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Reflection.Metadata;

namespace CodeWars
{
    public static class NumberLineJumpsResult
    {
        /* Complete the 'kangaroo' function below.
        *
        * The function is expected to return a STRING.
        * The function accepts following parameters:
        *  1. INTEGER x1
        *  2. INTEGER v1
        *  3. INTEGER x2
        *  4. INTEGER v2
        */

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int x1Position = x1;
            int x2Position = x2;

            for (int i = 0; i < 10000; i++)
            {
                x1Position = x1Position + v1;
                x2Position = x2Position + v2;

                if (x1Position == x2Position)
                {
                    return "YES";
                }
            }

            return "NO";
        }
    }

    [TestFixture]
    public class NumberLineJumpsSolution
    {
        [Test]
        public void NodeListOfTwoItemsReturnsTwoItems()
        {
            var result = NumberLineJumpsResult.kangaroo(0, 3, 4, 2);

            Assert.That(result, Is.EqualTo("YES"));
        }
    }
}
