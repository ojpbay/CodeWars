using System.Collections.Generic;

namespace CodeWars
{
    public static class MultipleOfThreeAndFive
    {
        public static int Solution(int value)
        {
            var result = 0;
            for (int i = value - 1; i > 0; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            return result;
        }    
    }
}
