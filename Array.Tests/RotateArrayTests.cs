using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems.Tests
{
    [TestFixture]
    public class RotateArrayTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 3, 4, 5, 1, 2 })]
        [TestCase(new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, 3, new int[] { 8, 10, 12, 14, 16, 18, 20, 2, 4, 6 })]
        public void RotateArrayVersionOne_ElementsRotated_ReturnsTrue(int[] test, int numOfRotation, int[] expected)
        {
            // act
            RotateArray rotateArray = new RotateArray();
            var result = rotateArray.RotateArrayVersionOne(test, numOfRotation);

            // assert
            Assert.AreEqual(result, expected);
        }
    }
}
