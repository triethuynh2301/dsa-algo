using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LinkedList.Tests
{
    public class IntersectionPointTwoListTests
    {
        #region Test solution 1 for FindIntersectionNode method
        [Fact]
        public void FindIntersecionNodeI_TwoListsInter_ReturnsInterNode()
        {
            // arrange
            SLinkedList<int> fstList = new SLinkedList<int>();
            SLinkedList<int> secList = new SLinkedList<int>();
            SLinkedList<int>.Node<int> interNode = new SLinkedList<int>.Node<int>(12);

            // 1st list
            fstList.InsertAtEnd(13);
            fstList.InsertAtEnd(4);
            // 2nd list
            secList.InsertAtEnd(29);
            secList.InsertAtEnd(23);
            secList.InsertAtEnd(82);
            secList.InsertAtEnd(11);
            // insert intersection node
            SLinkedList<int>.Node<int> current = fstList.head;
            while (current.nextNode != null)
            {
                current = current.nextNode;
            }
            current.nextNode = interNode;
            fstList.size++;

            current = secList.head;
            while (current.nextNode != null)
            {
                current = current.nextNode;
            }
            current.nextNode = interNode;
            secList.size++;

            // act
            var expected = IntersectionPointTwoLists<int>.FindIntersectionNodeI(fstList, secList);

            // assert
            expected.Should().BeEquivalentTo(interNode);
        }

        [Fact]
        public void FindIntersectionNodeI_NoIntersection_ReturnsNull()
        {
            // arrange
            SLinkedList<int> fstList = new SLinkedList<int>();
            SLinkedList<int> secList = new SLinkedList<int>();

            // 1st list
            fstList.InsertAtEnd(13);
            fstList.InsertAtEnd(4);
            fstList.InsertAtEnd(12);
            // 2nd list
            secList.InsertAtEnd(29);
            secList.InsertAtEnd(23);
            secList.InsertAtEnd(82);
            secList.InsertAtEnd(11);
            fstList.InsertAtEnd(12);

            // act
            var expected = IntersectionPointTwoLists<int>.FindIntersectionNodeI(fstList, secList);

            // assert
            expected.Should().BeNull();
        }
        #endregion

        #region Test solution 2 for FindIntersectionNode method
        [Fact]
        public void FindIntersecionNodeII_TwoListsInter_ReturnsInterNode()
        {
            // arrange
            SLinkedList<int> fstList = new SLinkedList<int>();
            SLinkedList<int> secList = new SLinkedList<int>();
            SLinkedList<int>.Node<int> interNode = new SLinkedList<int>.Node<int>(12);

            // 1st list
            fstList.InsertAtEnd(13);
            fstList.InsertAtEnd(4);
            // 2nd list
            secList.InsertAtEnd(29);
            secList.InsertAtEnd(23);
            secList.InsertAtEnd(82);
            secList.InsertAtEnd(11);
            // insert intersection node
            SLinkedList<int>.Node<int> current = fstList.head;
            while (current.nextNode != null)
            {
                current = current.nextNode;
            }
            current.nextNode = interNode;
            fstList.size++;

            current = secList.head;
            while (current.nextNode != null)
            {
                current = current.nextNode;
            }
            current.nextNode = interNode;
            secList.size++;

            // act
            var expected = IntersectionPointTwoLists<int>.FindIntersectionNodeII(fstList, secList);

            // assert
            expected.Should().BeEquivalentTo(interNode);
        }

        [Fact]
        public void FindIntersectionNodeII_NoIntersection_ReturnsNull()
        {
            // arrange
            SLinkedList<int> fstList = new SLinkedList<int>();
            SLinkedList<int> secList = new SLinkedList<int>();

            // 1st list
            fstList.InsertAtEnd(13);
            fstList.InsertAtEnd(4);
            fstList.InsertAtEnd(12);
            // 2nd list
            secList.InsertAtEnd(29);
            secList.InsertAtEnd(23);
            secList.InsertAtEnd(82);
            secList.InsertAtEnd(11);
            fstList.InsertAtEnd(12);

            // act
            var expected = IntersectionPointTwoLists<int>.FindIntersectionNodeII(fstList, secList);

            // assert
            expected.Should().BeNull();
        }
        #endregion

        #region Test solution 3 for FindIntersectionNode method
        [Fact]
        public void FindIntersecionNodeIII_TwoListsInter_ReturnsInterNode()
        {
            // arrange
            SLinkedList<int> fstList = new SLinkedList<int>();
            SLinkedList<int> secList = new SLinkedList<int>();
            SLinkedList<int>.Node<int> interNode = new SLinkedList<int>.Node<int>(12);

            // 1st list
            fstList.InsertAtEnd(13);
            fstList.InsertAtEnd(4);
            // 2nd list
            secList.InsertAtEnd(29);
            secList.InsertAtEnd(23);
            secList.InsertAtEnd(82);
            secList.InsertAtEnd(11);
            // insert intersection node
            SLinkedList<int>.Node<int> current = fstList.head;
            while (current.nextNode != null)
            {
                current = current.nextNode;
            }
            current.nextNode = interNode;
            fstList.size++;

            current = secList.head;
            while (current.nextNode != null)
            {
                current = current.nextNode;
            }
            current.nextNode = interNode;
            secList.size++;

            // act
            var expected = IntersectionPointTwoLists<int>.FindIntersectionNodeIII(fstList, secList);

            // assert
            expected.Should().BeEquivalentTo(interNode);
        }

        [Fact]
        public void FindIntersectionNodeIII_NoIntersection_ReturnsNull()
        {
            // arrange
            SLinkedList<int> fstList = new SLinkedList<int>();
            SLinkedList<int> secList = new SLinkedList<int>();

            // 1st list
            fstList.InsertAtEnd(13);
            fstList.InsertAtEnd(4);
            fstList.InsertAtEnd(12);
            // 2nd list
            secList.InsertAtEnd(29);
            secList.InsertAtEnd(23);
            secList.InsertAtEnd(82);
            secList.InsertAtEnd(11);
            fstList.InsertAtEnd(12);

            // act
            var expected = IntersectionPointTwoLists<int>.FindIntersectionNodeII(fstList, secList);

            // assert
            expected.Should().BeNull();
        }
        #endregion
    }
}
