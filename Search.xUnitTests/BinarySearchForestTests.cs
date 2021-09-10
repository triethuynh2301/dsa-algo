using Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Search.xUnitTests
{
    public class BinarySearchForestTests
    {
        #region Test support function
        [Theory]
        [InlineData(new[] { 1, 7, 6, 3, 4, 7 }, 6, 4, 8)]
        public void SumWoodCollected_CalculateSum_ReturnsTrue(int[] test, int arrSize, int height, int actual)
        {
            // act
            var testObj = new BinarySearchInForest();
            int expected = testObj.SumWoodCollected(height, test, arrSize);

            // assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Test method 1
        [Theory]
        [InlineData(new[] {2, 3, 6, 2, 4 }, 5, 4, 3)]
        [InlineData(new[] { 1, 7, 6, 3, 4, 7 }, 6, 8, 4)]
        [InlineData(new[] { 1, 7, 6, 3, 4, 7 }, 6, 5, 5)]
        public void FindHeightMethodOne_HeightFound_ReturnsTrue(int[] test, int arrSize, int woodCollected, int actual)
        {
            // act
            var testObj = new BinarySearchInForest();
            int expected = testObj.FindHeightMethodOne(test, arrSize, woodCollected);

            // assert
            Assert.Equal(expected, actual);
        }
        #endregion

        [Theory]
        [InlineData(new[] { 2, 3, 6, 2, 4 }, 5, 4, 3)]
        [InlineData(new[] { 1, 7, 6, 3, 4, 7 }, 6, 8, 4)]
        [InlineData(new[] { 1, 7, 6, 3, 4, 7 }, 6, 5, 5)]
        public void FindHeightMethodTwo_HeightFound_ReturnsTrue(int[] test, int arrSize, int woodCollected, int actual)
        {
            // act
            var testObj = new BinarySearchInForest();
            int expected = testObj.FindHeightMethodTwo(test, arrSize, woodCollected);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
