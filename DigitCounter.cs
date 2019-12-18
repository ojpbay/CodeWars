using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public static class DigitCounter
    {
        public static int SumDigits(int number)
        {
            var intList = Math.Abs(number).ToString().Select(digit => int.Parse(digit.ToString()));
            return intList.Sum();
        }
    }
}
