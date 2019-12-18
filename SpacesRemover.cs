using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {
            return new string(input.ToCharArray().Where(c => c.ToString() != " ").ToArray());
        }
    }
}
