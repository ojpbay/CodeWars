using NUnit.Framework;
using System;

namespace CodeWars
{
    public static class CatAndMouseResult
    {
        internal static string catAndMouse(int x, int y, int z)
        {
            var catADistance = Math.Abs(x - z);
            var CatBDistance = Math.Abs(y - z);

            if (catADistance == CatBDistance)
            {
                return "Mouse C";
            }

            return catADistance < CatBDistance ? "Cat A" : "Cat B";
        }
    }

    [TestFixture]
    public class CatAndMouseSolution
    {
        [Test]
        public void CatBNearer()
        {
            var result = CatAndMouseResult.catAndMouse(1, 2, 3);

            Assert.That(result, Is.EqualTo("Cat B"));
        }

        [Test]
        public void CatAAndCatBEquallyNear_MouseEscapes()
        {
            var result = CatAndMouseResult.catAndMouse(1, 3, 2);

            Assert.That(result, Is.EqualTo("Mouse C"));
        }
    }
}
