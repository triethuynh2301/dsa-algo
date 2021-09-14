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
