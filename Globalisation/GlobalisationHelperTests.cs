using NUnit.Framework;

namespace CodeWars.Globalisation
{
    [TestFixture]
    public class GlobalisationHelperTests
    {
        [Theory]
        [TestCase("en-GB", 1234567.89, "1,234,567.89")]
        [TestCase("en-US", 1234567.89, "1,234,567.890")]
        [TestCase("fr-FR", 1234567.89, "1 234 567,890")]
        [TestCase("it-IT", 1234567.89, "1.234.567,890")]

        public void GetLocalisedNumber(string locale, decimal number, string expected)
        {
            var result = GlobalisationHelper.GetLocalisedValue(number, locale);
            Assert.That(result.Equals(expected));
        }

        [Theory]
        [TestCase("en-GB", 1234567.123456, "1234567.123456%")]
        [TestCase("en-US", 1234567.123456, "1234567.123456%")]
        [TestCase("fr-FR", 1234567.123456, "1234567,123456%")]
        [TestCase("it-IT", 1234567.123456, "1234567,123456%")]
        [TestCase("pt-BR", 1234567.123456, "1234567,123456%")]

        public void GetLocalisedPercentageNumber(string locale, decimal number, string expected)
        {
            var result = GlobalisationHelper.GetLocalisedPercentageValue(number, locale, "#.######%");
            Assert.That(result.Equals(expected));
        }

        [Theory]
        [TestCase("en-GB", 1234567.123456, "1,234,567.123456%")]
        [TestCase("en-US", 1234567.123456, "1,234,567.123456%")]
        [TestCase("fr-FR", 1234567.123456, "1 234 567,123456%")]
        [TestCase("it-IT", 1234567.123456, "1.234.567,123456%")]
        [TestCase("pt-BR", 1234567.123456, "1.234.567,123456%")]

        public void GetLocalisedPercentageNumberWithThousandSeparator(string locale, decimal number, string expected)
        {
            var result = GlobalisationHelper.GetLocalisedPercentageValue(number, locale, "#,###.######%");
            Assert.That(result.Equals(expected));
        }
    }
}