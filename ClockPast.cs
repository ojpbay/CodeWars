using System;

namespace CodeWars
{
    public static class ClockPast
    {
        public static int CountAfterMidnight(int h, int m, int s)
        {
            var time = new TimeSpan(h, m, s);
            return (int)time.TotalMilliseconds;
        }
    }
}
