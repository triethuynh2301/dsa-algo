using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArrayProblems.xUnitTests
{
    public class SubarrayWithGivenSumTests
    {

        #region Test for SubarraySumMethodOne(int[] arr, int n, int s)
        [Fact]
        public void SubarraySumMethodOne_FindOSubarray_ReturnsTrue()
        {
            // Arrange
            int[] testArr = { 1, 2, 3, 7, 5 };
            int givenSum = 12;
            List<int> expected = new List<int>() { 2, 4 };

            // Act
            SubarrayWithGivenSum testObj = new SubarrayWithGivenSum();
            List<int> actual = testObj.SubarraySumMethodOne(testArr, testArr.Length, givenSum);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void SubarraySumMethodOne_NoSubarray_ReturnsTrue()
        {
            // Arrange
            int[] testArr = { 1, 2, 3, 7, 5 };
            int givenSum = 30;
            List<int> expected = new List<int>() { -1 };

            // Act
            SubarrayWithGivenSum testObj = new SubarrayWithGivenSum();
            List<int> actual = testObj.SubarraySumMethodOne(testArr, testArr.Length, givenSum);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void SubarraySumMethodOne_LargeInput_ReturnsTrue()
        {
            // Arrange
            int[] testArr = { 135, 101, 170, 125, 79, 159, 163, 65, 106, 146, 82, 28, 162, 92, 196, 143, 28, 37, 192, 5, 103, 154, 93, 183, 22, 117, 119, 96, 48, 127, 172, 139, 70, 113, 68, 100, 36, 95, 104, 12, 123, 134 };
            int givenSum = 468;
            List<int> expected = new List<int>() { 38, 42 };

            // Act
            SubarrayWithGivenSum testObj = new SubarrayWithGivenSum();
            List<int> actual = testObj.SubarraySumMethodOne(testArr, testArr.Length, givenSum);

            // Assert
            Assert.Equal(actual, expected);
        }
        #endregion

        #region Test for SubarraySumMethodTwo(int[] arr, int n, int s)
        [Fact]
        public void SubarraySumMethodTwo_FindOneSubarray_ReturnsTrue()
        {
            // Arrange
            int[] testArr = { 1, 2, 3, 7, 5 };
            int givenSum = 12;
            List<int> expected = new List<int>() { 2, 4 };

            // Act
            SubarrayWithGivenSum testObj = new SubarrayWithGivenSum();
            List<int> actual = testObj.SubarraySumMethodTwo(testArr, testArr.Length, givenSum);

            // Assert
            Assert.Equal(actual, expected);
        }


        [Fact]
        public void SubarraySumMethodTwo_LargeInput_ReturnsTrue()
        {
            // Arrange
            int[] testArr = { 135, 101, 170, 125, 79, 159, 163, 65, 106, 146, 82, 28, 162, 92, 196, 143, 28, 37, 192, 5, 103, 154, 93, 183, 22, 117, 119, 96, 48, 127, 172, 139, 70, 113, 68, 100, 36, 95, 104, 12, 123, 134 };
            int givenSum = 468;
            List<int> expected = new List<int>() { 38, 42 };

            // Act
            SubarrayWithGivenSum testObj = new SubarrayWithGivenSum();
            List<int> actual = testObj.SubarraySumMethodTwo(testArr, testArr.Length, givenSum);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void SubarraySumMethodTwo_NoSubarray_ReturnsTrue()
        {
            // Arrange
            int[] testArr = { 1, 2, 3, 7, 5 };
            int givenSum = 30;
            List<int> expected = new List<int>() { -1 };

            // Act
            SubarrayWithGivenSum testObj = new SubarrayWithGivenSum();
            List<int> actual = testObj.SubarraySumMethodTwo(testArr, testArr.Length, givenSum);

            // Assert
            Assert.Equal(actual, expected);
        }
        #endregion
    }
}
