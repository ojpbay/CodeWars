using System.Globalization;

namespace CodeWars
{
    public static class GlobalisationHelper
    {
        public static string GetLocalisedValue(decimal number, string locale)
        {
            return number.ToString("N", new CultureInfo(locale));
        }

        public static string GetLocalisedPercentageValue(decimal number, string locale, string format)
        {
            return (number / 100).ToString(format, new CultureInfo(locale));
        }
    }
}