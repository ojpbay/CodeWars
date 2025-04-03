using NUnit.Framework;
using System;

namespace CodeWars
{
    public static class DrawingBookResult
    {
        /*
         * Complete the 'pageCount' function below.
         * 
         * User can start at the start or the end of the book
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n (no. of pages in the book)
         *  2. INTEGER p (target page of the book)
         */

        public static int PageCount(int n, int p)
        {
            throw new NotImplementedException();
        }
    }

    [TestFixture]
    public class DrawingBookSolution
    {
        [Test]
        public void BookHas6Pages_TargetPage2_NumberOfPageTurnsEquals1()
        {
            var pageCount = DrawingBookResult.PageCount(6, 2);

            Assert.That(pageCount, Is.EqualTo(1));
        }

        [Test]
        public void BookHas5Pages_TargetPage4_NumberOfPageTurnsEquals0()
        {
            var pageCount = DrawingBookResult.PageCount(6, 2);

            Assert.That(pageCount, Is.EqualTo(1));
        }
    }
}
