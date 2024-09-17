using NUnit.Framework;

namespace CodeWars
{
    public static class TimeConversionResult
    {

        /*
         * Complete the 'timeConversion' function below.
         * https://www.hackerrank.com/challenges/one-month-preparation-kit-time-conversion/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=preparation-kits&playlist_slugs%5B%5D=one-month-preparation-kit&playlist_slugs%5B%5D=one-month-week-one
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string timeConversion(string s)
        {
            // string is in format "12:01:00PM"

            var hour = int.Parse(s.Substring(0, 2));
            var amPm = s.Substring(8, 2);

            if (amPm.ToUpperInvariant() == "PM" && hour != 12)
            {
                hour += 12;
            }
            else if (amPm.ToUpperInvariant() == "AM" && hour == 12)
            {
                hour = 0;
            }

            return hour.ToString("00") + s.Substring(2, 6);
        }

    }

    [TestFixture]
    public class TimeConversionSolution
    {
        [Test]
        public void Given120100AM_Returns000100()
        {
            var input = "12:01:00AM";
            var expected = "00:01:00";

            var result = TimeConversionResult.timeConversion(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Given120100PM_Returns120100()
        {
            var input = "12:01:00PM";
            var expected = "12:01:00";

            var result = TimeConversionResult.timeConversion(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Given010100PM_Returns130100()
        {
            var input = "01:01:00PM";
            var expected = "13:01:00";

            var result = TimeConversionResult.timeConversion(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
