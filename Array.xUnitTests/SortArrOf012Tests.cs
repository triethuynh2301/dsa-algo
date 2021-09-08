using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArrayProblems.xUnitTests
{
    
    public class SortArrOf012Tests
    {
        [Theory]
        [InlineData(new int[] {0, 2, 1, 2, 0 }, 5, new int[] { 0, 0, 1, 2, 2})]
        [InlineData(new int[] {0, 1, 0}, 3, new int[] { 0, 0, 1})]
        [InlineData(new int[] 
        {2, 0, 2, 0, 0,
         1, 2, 2, 2, 1,
         1, 0, 1, 1, 1,
         2, 0, 1, 2, 1,
         0, 1, 2, 0, 1},
            25,
            new int[] 
            { 0, 0, 0, 0, 0,
              0, 0, 1, 1, 1,
              1, 1, 1, 1, 1,
              1, 1, 2, 2, 2, 
              2, 2, 2, 2, 2})]
        public void Sort012_ArrSorted_ReturnsTrue(int[] test, int arrSize, int[] expected)
        {
            // act
            var sort012 = new SortArrOf012();
            sort012.Sort012(test, arrSize);

            // assert
            Assert.Equal(test, expected);
        }
    }
}
