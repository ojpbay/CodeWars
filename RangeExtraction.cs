using NUnit.Framework;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public static class RangeExtraction
    {
        // return a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. The range includes all integers in the interval including both endpoints. It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"            
        public static string Extract(int[] args)
        {
            var orderedInts = args.OrderBy(x => x).ToArray();
            var sb = new StringBuilder();

            for (int i = 0; i < orderedInts.Length; i++)
            {
                int current = orderedInts[i];
                int next = i + 1 < orderedInts.Length ? orderedInts[i + 1] : -99;
                int previous = i - 1 >= 0 ? orderedInts[i - 1] : -99;

                // start of a sequence
                if (i == 0 || current - previous > 1)
                {
                    sb.Append(current);

                    if (next - current > 1 && i != orderedInts.Length - 1)
                    {
                        sb.Append(",");
                    }

                    continue;
                }

                // middle of a sequence
                if (previous == current - 1 && next == current + 1)
                {
                    if (!sb.ToString().EndsWith("-"))
                    {
                        sb.Append("-");
                        continue;
                    }
                }
                else if (current - previous > 1 || (current - previous == 1 && (next - current > 1 || i == orderedInts.Length - 1)))
                {
                    if (!sb.ToString().EndsWith(",") && !sb.ToString().EndsWith("-"))
                    {
                        sb.Append(",");
                    }
                }

                // end of a sequence
                if (i == orderedInts.Length - 1 || next - current > 1)
                {
                    sb.Append(current);

                    if (next - current > 1 && i != orderedInts.Length - 1)
                    {
                        sb.Append(",");
                    }

                    continue;
                }
            }

            return sb.ToString();
        }
    }

    [TestFixture]
    public class RangeExtractionTests
    {
        [Test(Description = "Simple tests")]
        public void SimpleTests1()
        {
            Assert.That(RangeExtraction.Extract(new[] { 1, 2 }), Is.EqualTo("1,2"));
        }

        [Test(Description = "Simple tests")]
        public void SimpleTests2()
        {
            Assert.That(RangeExtraction.Extract(new[] { 1, 2, 3 }), Is.EqualTo("1-3"));
        }

        [Test(Description = "Simple tests")]
        public void SimpleTests3()
        {
            Assert.That(
                RangeExtraction.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 }),
                Is.EqualTo("-6,-3-1,3-5,7-11,14,15,17-20")
            );
        }

        [Test(Description = "Simple tests")]
        public void SimpleTests4()
        {
            Assert.That(
                RangeExtraction.Extract(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 }),
                Is.EqualTo("-3--1,2,10,15,16,18-20")
            );
        }
    }
}
