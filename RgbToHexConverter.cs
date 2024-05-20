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
            input = Math.Clamp(input, 0, 255);

            var hex = input.ToString("X");

            if (hex.Length == 1)
            {
                hex = $"0{hex}";
            }

            return hex;
        }
    }
}
