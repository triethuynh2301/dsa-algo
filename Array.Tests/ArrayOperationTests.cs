using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems.Tests
{
    [TestFixture]
    public class ArrayOperationTests
    {
        private List<int> testCase = null;

        [SetUp]
        public void Setup()
        {
            testCase = new List<int> { 1, 8, 7, 56, 90 };
        }

        [Test]
        public void Max_GetArrayMaxValue_ReturnsTrue()
        {
            // act
            int result = testCase.Max();

            // assert
            Assert.AreEqual(result, 90);
        }

        [Test]
        public void Min_GetArrayMinValue_ReturnsTrue()
        {
            // act 
            int result = testCase.Min();

            // assert
            Assert.AreEqual(result, 1);
        }

        [TestCase(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 2, 3, 4, 4, 4, 5, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 })]
        public void RemoveDuplicates_UniqueElements_ReturnsTrue(int[] arr, int[] nonDuplicateArr)
        {
            // act
            int numberOfUniqueElements = arr.RemoveDuplicates();
            arr = arr.Take(numberOfUniqueElements)
                        .ToArray();

            // assert
            Assert.AreEqual(arr, nonDuplicateArr);
        }

        [TearDown]
        public void TearDown()
        {
            testCase = null;
        }
    }
}
