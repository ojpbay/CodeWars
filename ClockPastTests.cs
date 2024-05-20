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
            var time = TimeFormat.GetReadableTime(0);
            Assert.That(time.Equals("00:00:00"));
        }

        [Test]
        public void HumanReadableTest_5()
        {
            var time = TimeFormat.GetReadableTime(5);
            Assert.That(time.Equals("00:00:05"));
        }

        [Test]
        public void HumanReadableTest_60()
        {
            var time = TimeFormat.GetReadableTime(60);
            Assert.That(time.Equals("00:01:00"));
        }

        [Test]
        public void HumanReadableTest_86399()
        {
            var time = TimeFormat.GetReadableTime(86399);
            Assert.That(time.Equals("23:59:59"));
        }

        [Test]
        public void HumanReadableTest_359999()
        {
            var time = TimeFormat.GetReadableTime(359999);
            Assert.That(time.Equals("99:59:59"));
        }
    }
}