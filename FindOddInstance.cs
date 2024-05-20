
using System.Linq;

namespace CodeWars
{
    public static class FindOddInstance
    {
        public static int FindIt(int[] seq)
        {
            return seq.First(n => seq.Count(innerN => n == innerN) % 2 != 0);
        }
    }
}
