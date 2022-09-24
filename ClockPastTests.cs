using System;
using NUnit.Framework;

namespace CodeWars
{
    public static class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            TimeSpan ts = TimeSpan.FromSeconds(seconds);

            if (ts.Days > 0)
            {
                return "99:59:59";
            }
            return ts.ToString(@"hh\:mm\:ss");
        }
    }



    [TestFixture]
    public class HumanReadableTimeTest
    {
        [Test]
        public void HumanReadableTest_0()
        {
            Assert.AreEqual("00:00:00", TimeFormat.GetReadableTime(0));
        }

        [Test]
        public void HumanReadableTest_5()
        {
            Assert.AreEqual("00:00:05", TimeFormat.GetReadableTime(5));
        }

        [Test]
        public void HumanReadableTest_60()
        {
            Assert.AreEqual("00:01:00", TimeFormat.GetReadableTime(60));
        }

        [Test]
        public void HumanReadableTest_86399()
        {
            Assert.AreEqual("23:59:59", TimeFormat.GetReadableTime(86399));
        }

        [Test]
        public void HumanReadableTest_359999()
        {
            Assert.AreEqual("99:59:59", TimeFormat.GetReadableTime(359999));
        }
    }
}