using System.Numerics;

namespace CodeWars
{
    public static class SumStringsAsNumbers
    {
        public static string sumStrings(string a, string b)
        {
            BigInteger bigIntA = 0;
            BigInteger bingIntB = 0;

            BigInteger.TryParse(a, out bigIntA);
            BigInteger.TryParse(b, out bingIntB);
            return (bigIntA + bingIntB).ToString();
        }
    }
}
