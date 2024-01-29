using NUnit.Framework;

namespace CodeWars.Globalisation
{
    [TestFixture]
    public class GlobalisationHelperTests
    {
        [Theory]
        [TestCase("en-GB", 1234567.89, "1,234,567.89")]
        [TestCase("en-US", 1234567.89, "1,234,567.890")]
        [TestCase("fr-FR", 1234567.89, "1 234 567,890")]
        [TestCase("it-IT", 1234567.89, "1.234.567,890")]

        public void GetLocalisedNumber(string locale, double number, string expected)
        {
            Assert.AreEqual(expected, GlobalisationHelper.GetLocalisedValue(number, locale));
        }
    }
}