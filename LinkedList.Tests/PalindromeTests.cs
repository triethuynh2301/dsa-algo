using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LinkedList.Tests
{
    public class PalindromeTests
    {
        #region Test IsPalindrome(LinkedList<T> list)
        [Fact]
        public void IsPalindrome_SingleElementList_ReturnsTrue()
        {
            // arrange
            LinkedList<int> testList = new LinkedList<int>(new[] { 1 });

            // act
            var expected = Palindrome<int>.IsPalindrome(testList);

            // assert
            Assert.True(expected);
        }

        [Fact]
        public void IsPalindrome_PalindromeNums_ReturnsTrue()
        {
            // arrange
            LinkedList<int> testList = new LinkedList<int>(new[] { 1, 2, 3, 2, 1 });

            // act
            var expected = Palindrome<int>.IsPalindrome(testList);

            // assert
            Assert.True(expected);
        }

        [Fact]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            // arrange
            LinkedList<int> testList = new LinkedList<int>(new[] { 1, 2, 3 , 4 });

            // act
            var expected = Palindrome<int>.IsPalindrome(testList);

            // assert
            Assert.False(expected);
        }
        #endregion
    }
}
