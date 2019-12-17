
using System.Linq;

namespace CodeWars
{
    public static class FindOddInstance
    {
        public static int find_it(int[] seq)
        {
            return seq.Where(n => seq.Count(innerN => n == innerN) % 2 != 0).First();
        }
    }
}
