using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class EncodeText
    {
        public static string DuplicateEncode(string word)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var sb = new StringBuilder();
            BuildIndex(word, dict);

            foreach (char c in word)
            {
                var encoded = Encode(c, dict);
                sb.Append(encoded);
            }

            return sb.ToString();
        }

        private static void BuildIndex(string word, Dictionary<string, int> dict)
        {
            foreach (char c in word)
            {
                var key = c.ToString().ToLowerInvariant();
                if (!dict.ContainsKey(c.ToString().ToLowerInvariant()))
                {
                    dict.Add(key, 1);
                }
                else
                {
                    var val = dict[key];
                    val++;

                    // not incrementing value
                    dict[key] = val;
                }
            }
        }

        private static string Encode(char c, Dictionary<string, int> dict)
        {
            var count = dict[c.ToString().ToLowerInvariant()];

            if (count <= 1)
            {
                return "(";
            }

            return ")";
        }
    }
}
