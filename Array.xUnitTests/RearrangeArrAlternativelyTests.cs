using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArrayProblems.xUnitTests
{
    public class RearrangeArrAlternativelyTests
    {
        [Theory]
        [InlineData(new int[] {1, 2, 3, 4, 5, 6}, 6, new int[] {6, 1, 5, 2, 4, 3})]
        [InlineData(new int[] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110 }, 11,
            new int[] { 110, 10, 100, 20, 90, 30, 80, 40, 70, 50, 60})]
        public void Rearrange_ArrRearranged_ReturnsTrue(int[] test, int arrSize, int[] expected)
        {
            // act
            RearrangeArrAlternatively testObj = new RearrangeArrAlternatively();
            testObj.Rearrange(test, arrSize);

            // assert
            Assert.Equal(test, expected);
        }
    }
}
