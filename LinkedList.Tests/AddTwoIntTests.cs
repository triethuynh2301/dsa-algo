using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using LinkedList;


namespace LinkedList.Tests
{
    public class AddTwoNumersTests
    {
        [Theory]
        [InlineData(11, 1)]
        [InlineData(10, 0)]
        [InlineData(8, 8)]
        public void GetLastDigit_ValidNum_ReturnsLastDigit(int num, int actual)
        {
            // act
            int expected = AddTwoNumbers.GetLastDigit(num);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddTwoNumbers_FirstListLonger_ReturnsSum()
        {
            // arrange
            LinkedList<int> fstList = new LinkedList<int>();
            fstList.AddLast(new LinkedListNode<int>(1));
            fstList.AddLast(new LinkedListNode<int>(0));
            fstList.AddLast(new LinkedListNode<int>(9));
            fstList.AddLast(new LinkedListNode<int>(9));

            LinkedList<int> secList = new LinkedList<int>();
            secList.AddLast(new LinkedListNode<int>(7));
            secList.AddLast(new LinkedListNode<int>(3));
            secList.AddLast(new LinkedListNode<int>(2));

            LinkedList<int> sum = new LinkedList<int>();
            sum.AddLast(new LinkedListNode<int>(8));
            sum.AddLast(new LinkedListNode<int>(3));
            sum.AddLast(new LinkedListNode<int>(1));
            sum.AddLast(new LinkedListNode<int>(0));
            sum.AddLast(new LinkedListNode<int>(1));

            // act
            LinkedList<int> expected = AddTwoNumbers.AddTwoIntegers(fstList, secList);

            // assert
            sum.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void AddTwoNumbers_SecondListLonger_ReturnsSum()
        {
            // arrange
            LinkedList<int> fstList = new LinkedList<int>();
            fstList.AddLast(new LinkedListNode<int>(2));
            fstList.AddLast(new LinkedListNode<int>(3));
            fstList.AddLast(new LinkedListNode<int>(7));

            LinkedList<int> secList = new LinkedList<int>();
            secList.AddLast(new LinkedListNode<int>(9));
            secList.AddLast(new LinkedListNode<int>(9));
            secList.AddLast(new LinkedListNode<int>(0));
            secList.AddLast(new LinkedListNode<int>(1));

            LinkedList<int> sum = new LinkedList<int>();
            sum.AddLast(new LinkedListNode<int>(1));
            sum.AddLast(new LinkedListNode<int>(3));
            sum.AddLast(new LinkedListNode<int>(8));
            sum.AddLast(new LinkedListNode<int>(1));

            // act
            LinkedList<int> expected = AddTwoNumbers.AddTwoIntegers(fstList, secList);

            // assert
            sum.Should().BeEquivalentTo(expected);
        }
    }
}
