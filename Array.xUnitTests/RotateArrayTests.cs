using System;
using Xunit;

namespace ArrayProblems.xUnitTests
{
    public class RotateArrayTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 3, 4, 5, 1, 2 })]
        [InlineData(new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, 3, new int[] { 8, 10, 12, 14, 16, 18, 20, 2, 4, 6 })]
        public void RotateArrayVersionTwo_ElementsRotated_ReturnsTrue(int[] test, int numOfRotation, int[] expected)
        {
            // act
            RotateArray rotateOneByOne = new RotateArray();
            var result = rotateOneByOne.RotateArrayVersionTwo(test, numOfRotation);

            // assert
            Assert.Equal(test, expected);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 3, 4, 5, 1, 2 })]
        [InlineData(new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, 3, new int[] { 8, 10, 12, 14, 16, 18, 20, 2, 4, 6 })]
        public void RotateArrayVersionThree_ElementsRotated_ReturnsTrue(int[] test, int numOfRotation, int[] expected)
        {
            // act
            RotateArray rotateOneByOne = new RotateArray();
            var result = rotateOneByOne.RotateArrayVersionThree(test, numOfRotation);

            // assert
            Assert.Equal(test, expected);
        }
    }
}
