using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArrayProblems.xUnitTests
{
    public class MajorityElementTests
    {
        [Fact]
        #region Test MajorityElementMethodOne()
        public void MajorityElementMethodOne_FindOneMajorElement_ReturnsTrue()
        {
            // arrange
            int[] test = new int[] { 3, 1, 3, 3, 2 };
            int expected = 3;

            // act
            MajorityElement testObj = new MajorityElement();
            int actual = testObj.MajorityElementMethodOne(test, test.Length);

            // assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MajorityElementMethodOne_NoMajorElement_ReturnsTrue()
        {
            // arrange
            int[] test = new int[] { 1, 2, 3 };
            int expected = -1;

            // act
            MajorityElement testObj = new MajorityElement();
            int actual = testObj.MajorityElementMethodOne(test, test.Length);

            // assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MajorityElementMethodOne_InputArrContainOneElement_ReturnsTrue()
        {
            // arrange
            int[] test = new int[] { 15 };
            int expected = 15;

            // act
            MajorityElement testObj = new MajorityElement();
            int actual = testObj.MajorityElementMethodOne(test, test.Length);

            // assert
            Assert.Equal(actual, expected);
        }
        #endregion

        #region Test MajorityElementMethodTwo()
        [Fact]
        public void MajorityElementMethodTwo_FindOneMajorElement_ReturnsTrue()
        {
            // arrange
            int[] test = new int[] { 3, 1, 3, 3, 2 };
            int expected = 3;

            // act
            MajorityElement testObj = new MajorityElement();
            int actual = testObj.MajorityElementMethodTwo(test, test.Length);

            // assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MajorityElementMethodTwo_NoMajorElement_ReturnsTrue()
        {
            // arrange
            int[] test = new int[] { 1, 2, 3 };
            int expected = -1;

            // act
            MajorityElement testObj = new MajorityElement();
            int actual = testObj.MajorityElementMethodTwo(test, test.Length);

            // assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MajorityElementMethodTwo_InputArrContainOneElement_ReturnsTrue()
        {
            // arrange
            int[] test = new int[] { 15 };
            int expected = 15;

            // act
            MajorityElement testObj = new MajorityElement();
            int actual = testObj.MajorityElementMethodTwo(test, test.Length);

            // assert
            Assert.Equal(actual, expected);
        }
        #endregion

        #region Test MajorityElementMethodThree()
        [Fact]
        public void MajorityElementMethodThree_FindOneMajorElement_ReturnsTrue()
        {
            // arrange
            int[] test = new int[] { 3, 1, 3, 3, 2 };
            int expected = 3;

            // act
            MajorityElement testObj = new MajorityElement();
            int actual = testObj.MajorityElementMethodThree(test, test.Length);

            // assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MajorityElementMethodThree_NoMajorElement_ReturnsTrue()
        {
            // arrange
            int[] test = new int[] { 1, 2, 3 };
            int expected = -1;

            // act
            MajorityElement testObj = new MajorityElement();
            int actual = testObj.MajorityElementMethodThree(test, test.Length);

            // assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MajorityElementMethodThree_InputArrContainOneElement_ReturnsTrue()
        {
            // arrange
            int[] test = new int[] { 15 };
            int expected = 15;

            // act
            MajorityElement testObj = new MajorityElement();
            int actual = testObj.MajorityElementMethodThree(test, test.Length);

            // assert
            Assert.Equal(actual, expected);
        }
        #endregion


    }
}
