using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public static class RgbToHexConverter
    {
        public static string Rgb(int r, int g, int b)
        {
            var sb = new StringBuilder();

            sb.Append(Format(r));
            sb.Append(Format(g));
            sb.Append(Format(b));

            return sb.ToString().ToUpper();
        }

        private static string Format(int input)
        {
            input = (input < 0 ? 0 : input > 255 ? 255 : input);

            var i = input.ToString("X");

            if (i == "0")
            {
                return "00";
            }

            if (i.Length == 1)
            {
                i = string.Format($"0{i}");
            }

            return i;
        }
    }
}
