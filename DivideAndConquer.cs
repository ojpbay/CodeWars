using NUnit.Framework;
using System;
using System.Linq;


namespace CodeWars
{
    public static class DivideAndConquer
    {
        public static int DivCon(Object[] objArray)
        {
            var sumNumbers = objArray.Where(x => x is int).Sum(x => (int)x);
            var sumStrings = objArray.Where(x => x is string).Sum(x => int.Parse((string)x));

            return sumNumbers - sumStrings;
        }
    }


    [TestFixture]
    public class DivideAndConquerTest
    {
        [Test]
        public void SampleTest1()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { 9, 3, "7", "3" }), Is.EqualTo(2));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }), Is.EqualTo(14));
        }

        [Test]
        public void SampleTest3()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }), Is.EqualTo(13));
        }

        [Test]
        public void SampleTest4()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { "1", "5", "8", 8, 9, 9, 2, "3" }), Is.EqualTo(11));
        }

        [Test]
        public void SampleTest5()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { 8, 0, 0, 8, 5, 7, 2, 3, 7, 8, 6, 7 }), Is.EqualTo(61));
        }

        [Test]
        public void SampleTest6()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { "0", "1", "2", "3" }), Is.EqualTo(-6));
        }

        [Test]
        public void SampleTest7()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { 0, 1, 2, 3 }), Is.EqualTo(6));
        }

        [Test]
        public void SampleTest8()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { 1, "1" }), Is.EqualTo(0));
        }

        [Test]
        public void SampleTest9()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { -1, "1" }), Is.EqualTo(-2));
        }

        [Test]
        public void SampleTest10()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { 1, "-1" }), Is.EqualTo(2));
        }

        [Test]
        public void SampleTest11()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { 1 }), Is.EqualTo(1));
        }

        [Test]
        public void SampleTest12()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { "1" }), Is.EqualTo(-1));
        }

        [Test]
        public void SampleTest13()
        {
            Assert.That(DivideAndConquer.DivCon(new object[] { }), Is.EqualTo(0));
        }
    }
}
