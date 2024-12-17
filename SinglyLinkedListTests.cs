using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWars
{
    public static class SinglyLinkedListNodeResult
    {
        internal static List<int> PrintLinkedList(SinglyLinkedListTests head)
        {
            var result = new List<int>();
            while (head != null)
            {
                result.Add(head.data);
                head = head.next;
            }
            return result;
        }
    }

    internal class SinglyLinkedListTests
    {
        public int data { get; set; }
        public SinglyLinkedListTests next { get; set; }
    }

    [TestFixture]
    public class SinglyLinkedListNodeSolution
    {
        [Test]
        public void NodeListOfTwoItemsReturnsTwoItems()
        {
            var result = SinglyLinkedListNodeResult.PrintLinkedList(new SinglyLinkedListTests { data = 16, next = new SinglyLinkedListTests { data = 13, next = null } });

            var expected = new List<int> { 16, 13 };

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
