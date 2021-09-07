using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Array.xUnitTests
{
    public class ArrayOperationTests
    {
        [Theory]
        [InlineData(new int[] {1, 2, 3, 4, 5 }, 0, 4, new int[] {5, 4, 3, 2, 1})]
        [InlineData(new int[] {1, 2, 3, 4, 5}, 2, 4, new int[] {1, 2, 5, 4, 3})]
        [InlineData(new int[] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20}, 0, 9, new int[] {20, 18, 16, 14, 12, 10, 8, 6, 4, 2})]
        public void ReverseArray_ElementsReversedFromStartIndexToEndIndex_ReturnsTrue(int[] arr, int startIndex, int endIndex, int[] expected)
        {
            // Act
            var result = arr.ReverseArrary(startIndex, endIndex);

            // Assert
            Assert.Equal(result, expected);
        }
    }
}
