using System.Globalization;

namespace CodeWars
{
    public static class GlobalisationHelper
    {
        public static string GetLocalisedValue(double number, string locale)
        {
            return number.ToString("N", new CultureInfo(locale));
        }
    }
}