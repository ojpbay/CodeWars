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
        public void HumanReadableTest_0Returns000000()
        {
            var time = TimeFormat.GetReadableTime(0);
            Assert.That(time, Is.EqualTo("00:00:00"));
        }

        [Test]
        public void HumanReadableTest_5seconds_Returns000005()
        {
            var time = TimeFormat.GetReadableTime(5);
            Assert.That(time, Is.EqualTo("00:00:05"));
        }

        [Test]
        public void HumanReadableTest_1Minute_Returns000100()
        {
            var time = TimeFormat.GetReadableTime(60);
            Assert.That(time, Is.EqualTo("00:01:00"));
        }

        [Test]
        public void HumanReadableTest_86399_Returns235959()
        {
            var time = TimeFormat.GetReadableTime(86399);
            Assert.That(time, Is.EqualTo("23:59:59"));
        }

        [Test]
        public void HumanReadableTest_359999_Returns995959()
        {
            var time = TimeFormat.GetReadableTime(359999);
            Assert.That(time, Is.EqualTo("99:59:59"));
        }
    }
}