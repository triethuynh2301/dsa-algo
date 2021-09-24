using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;


namespace LinkedList.Tests
{
    public class SLinkedListToolBoxTests
    {
        #region Test FindNthElementFromEnd(SLinkedList<T> list, int n)
        [Fact]
        public void FindNthElementFromEnd_ValidNthElementCaseOne_ReturnsElementValue()
        {
            // arrange
            var testList = new SLinkedList<int>();
            int expected = 8;
            testList.InsertAtEnd(15);
            testList.InsertAtEnd(22);
            testList.InsertAtEnd(8);
            testList.InsertAtEnd(7);
            testList.InsertAtEnd(14);
            testList.InsertAtEnd(21);

            // act
            var actual = SLinkedListToolBox<int>.FindNthElementFromEnd(testList, 4);

            // assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void FindNthElementFromEnd_ValidNthElementCaseTwo_ReturnsElementValue()
        {
            // arrange
            var testList = new SLinkedList<int>();
            int expected = 47;
            testList.InsertAtEnd(22);
            testList.InsertAtEnd(18);
            testList.InsertAtEnd(60);
            testList.InsertAtEnd(78);
            testList.InsertAtEnd(47);
            testList.InsertAtEnd(39);
            testList.InsertAtEnd(99);

            // act
            var actual = SLinkedListToolBox<int>.FindNthElementFromEnd(testList, 3);

            // assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void FindNthElementFromEnd_NthElementIndexOutOfRange_ReturnsNull()
        {
            // arrange
            var testList = new SLinkedList<int>();
            Object expected = null;
            testList.InsertAtEnd(22);
            testList.InsertAtEnd(18);
            testList.InsertAtEnd(60);
            testList.InsertAtEnd(78);
            testList.InsertAtEnd(47);
            testList.InsertAtEnd(39);
            testList.InsertAtEnd(99);

            // act
            var actual = SLinkedListToolBox<int>.FindNthElementFromEnd(testList, 10);

            // assert
            Assert.Equal(expected, actual);

        }
        #endregion

        #region Test Union(SLinkedList<T> list1, SLinkedList<T> list2)
        [Fact]
        public void Union_TwoListsWithDuplicates_ReturnsNonDuplicatesUnion()
        {
            // arrange
            SLinkedList<int> test1 = new SLinkedList<int>();
            SLinkedList<int> test2 = new SLinkedList<int>();
            SLinkedList<int> actual = new SLinkedList<int>();
            test1.InsertAtEnd(15);
            test1.InsertAtEnd(22);
            test1.InsertAtEnd(8);

            test2.InsertAtEnd(7);
            test2.InsertAtEnd(14);
            test2.InsertAtEnd(22);

            actual.InsertAtEnd(15);
            actual.InsertAtEnd(22);
            actual.InsertAtEnd(8);
            actual.InsertAtEnd(7);
            actual.InsertAtEnd(14);

            // act
            var expected = SLinkedListToolBox<int>.Union(test1, test2);

            // assert
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Union_OneEmptyList_ReturnsOtherList()
        {
            // arrange
            SLinkedList<int> test1 = new SLinkedList<int>();
            SLinkedList<int> test2 = new SLinkedList<int>();
            SLinkedList<int> actual = new SLinkedList<int>();
            test1.InsertAtEnd(15);
            test1.InsertAtEnd(22);
            test1.InsertAtEnd(8);

            actual.InsertAtEnd(15);
            actual.InsertAtEnd(22);
            actual.InsertAtEnd(8);

            // act
            var expected = SLinkedListToolBox<int>.Union(test1, test2);

            // assert
            actual.Should().BeEquivalentTo(expected);
        }


        #endregion

        #region Test Intersection(SLinkedList<T> list1, SLinkedList<T> list2)
        [Fact]
        public void Intersection_ContainsCommonElements_ReturnsIntersectionList()
        {
            // arrange
            SLinkedList<int> test1 = new SLinkedList<int>();
            SLinkedList<int> test2 = new SLinkedList<int>();
            SLinkedList<int> actual = new SLinkedList<int>();
            test1.InsertAtEnd(15);
            test1.InsertAtEnd(22);
            test1.InsertAtEnd(8);

            test2.InsertAtEnd(7);
            test2.InsertAtEnd(14);
            test2.InsertAtEnd(22);

            actual.InsertAtEnd(22);

            // act
            var expected = SLinkedListToolBox<int>.Intersection(test1, test2);

            // assert
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Intersection_OneListEmpty_ReturnsEmptyList()
        {
            // arrange
            SLinkedList<int> test1 = new SLinkedList<int>();
            SLinkedList<int> test2 = new SLinkedList<int>();
            SLinkedList<int> actual = new SLinkedList<int>();
            test1.InsertAtEnd(15);
            test1.InsertAtEnd(22);
            test1.InsertAtEnd(8);

            // act
            var expected = SLinkedListToolBox<int>.Intersection(test1, test2);

            // assert
            actual.Should().BeEquivalentTo(expected);
        }
        #endregion

        #region Test DetectLoop(SLinkedList<T> list)
        [Fact]
        public void DetectLoop_CircularLoop_ReturnsTrue()
        {

        }

        [Fact]
        public void DetectLoop_NonCircularLoop_ReturnsTrue()
        {

        }

        [Fact]
        public void DetectLoop_NoLoop_ReturnsFalse()
        {

        }
        #endregion

        #region Test FindMiddleMethodOne(SLinkedList<T> list)
        [Fact]
        public void FindMiddleMethodOne_EvenNodes_ReturnsMiddleNodeValue()
        {
            // arrange
            var testList = new SLinkedList<int>();
            testList.InsertAtEnd(7);
            testList.InsertAtEnd(14);
            testList.InsertAtEnd(10);
            testList.InsertAtEnd(21);

            // act
            int actual = SLinkedListToolBox<int>.FindMiddleMethodOne(testList);

            // assert
            Assert.Equal(14, actual);
        }

        [Fact]
        public void FindMiddleMethodOne_OddNodes_ReturnsMiddleNodeValue()
        {
            // arrange
            var testList = new SLinkedList<int>();
            testList.InsertAtEnd(7);
            testList.InsertAtEnd(14);
            testList.InsertAtEnd(10);
            testList.InsertAtEnd(21);
            testList.InsertAtEnd(22);

            // act
            int actual = SLinkedListToolBox<int>.FindMiddleMethodOne(testList);

            // assert
            Assert.Equal(10, actual);
        }
        #endregion

        #region Test FindMiddleMethodTwo(SLinkedList<T> list)
        [Fact]
        public void FindMiddleMethodTwo_EmptyList_ReturnsNull()
        {
            // arrange
            var testList = new SLinkedList<int>();

            // act
            Object actual = SLinkedListToolBox<int>.FindMiddleMethodTwo(testList);

            // assert
            Assert.Null(actual);
        }

        [Fact]
        public void FindMiddleMethodTwo_EvenNodes_ReturnsMiddleNodeValue()
        {
            // arrange
            var testList = new SLinkedList<int>();
            testList.InsertAtEnd(7);
            testList.InsertAtEnd(14);
            testList.InsertAtEnd(10);
            testList.InsertAtEnd(21);

            // act
            Object actual = SLinkedListToolBox<int>.FindMiddleMethodTwo(testList);

            // assert
            Assert.Equal(14, actual);
        }

        [Fact]
        public void FindMiddleMethodTwo_OddNodes_ReturnsMiddleNodeValue()
        {
            // arrange
            var testList = new SLinkedList<int>();
            testList.InsertAtEnd(1);
            testList.InsertAtEnd(2);
            testList.InsertAtEnd(123);
            testList.InsertAtEnd(101);
            testList.InsertAtEnd(66);

            // act
            Object actual = SLinkedListToolBox<int>.FindMiddleMethodTwo(testList);

            // assert
            Assert.Equal(123, actual);
        }
        #endregion

        #region Test RemoveDuplicatesMethodOne(SLinkedList<T> list)
        [Fact]
        public void RemoveDuplicatesMethodOne_DuplicatesList_ReturnsNonDuplicatesList()
        {
            // arrange
            var expected = new SLinkedList<int>();
            expected.InsertAtEnd(7);
            expected.InsertAtEnd(14);
            expected.InsertAtEnd(21);
            expected.InsertAtEnd(22);

            SLinkedList<int> testList = new SLinkedList<int>();
            testList.InsertAtEnd(7);
            testList.InsertAtEnd(14);
            testList.InsertAtEnd(21);
            testList.InsertAtEnd(14);
            testList.InsertAtEnd(22);
            testList.InsertAtEnd(7);

            // act
            SLinkedListToolBox<int>.RemoveDuplicatesMethodOne(testList);

            // assert
            expected.Should().BeEquivalentTo(testList);
        }

        [Fact]
        public void RemoveDuplicatesMethodOne_NoDuplicates_ReturnsList()
        {
            // arrange
            var expected = new SLinkedList<int>();
            expected.InsertAtEnd(7);
            expected.InsertAtEnd(14);
            expected.InsertAtEnd(21);
            expected.InsertAtEnd(22);

            SLinkedList<int> testList = new SLinkedList<int>();
            testList.InsertAtEnd(7);
            testList.InsertAtEnd(14);
            testList.InsertAtEnd(21);
            testList.InsertAtEnd(22);
            

            // act
            SLinkedListToolBox<int>.RemoveDuplicatesMethodOne(testList);

            // assert
            expected.Should().BeEquivalentTo(testList);
        }
        #endregion
    }
}
