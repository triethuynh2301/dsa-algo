/// <summary>
//Given an unsorted array arr[] of size N, rotate it by D elements (clockwise). 

//Input:
//The first line of the input contains T denoting the number of testcases. First line of each test case contains two space separated elements, N denoting the size of the array and an integer D denoting the number size of the rotation. Subsequent line will be the N space separated array elements.

//Output:
//For each testcase, in a new line, output the rotated array.

//Constraints:
//1 <= T <= 200
//1 <= N <= 107
//1 <= D <= N
//0 <= arr[i] <= 105

//Example:
//Input:
//2
//5 2
//1 2 3 4 5
//10 3
//2 4 6 8 10 12 14 16 18 20

//Output:
//3 4 5 1 2
//8 10 12 14 16 18 20 2 4 6

//Explanation:
//Testcase 1: 1 2 3 4 5  when rotated by 2 elements, it becomes 3 4 5 1 2.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class RotateArray
    {
        /// <summary>
        /// Using temp array to store items to rotate to back
        /// Shift the elements not needing to rotate to the front
        /// Place the items need rotation to the back from the temp arr
        /// </summary>
        public int[] RotateArrayVersionOne(int[] arr, int numOfRotation)
        {
            // store the items to be rotated to a temp container
            var containerArr = new int[numOfRotation];
            for (int i = 0; i < numOfRotation; i++)
            {
                containerArr[i] = arr[i];
            }

            // use two pointer technique to push the items to the front
            // first poiner to traverse arr starting from
            // location of item not rotated till the rest of array
            // second pointer points to location items should be pushed to
            int arrLength = arr.Count();
            int locationPointer = 0;
            int startIndex = numOfRotation ;
            for (int i = startIndex; i < arrLength; i++)
            {
                arr[locationPointer] = arr[i];
                locationPointer++;
            }

            // push the items from the container array to the back of the arr
            int containerArrPointer = 0;
            for (int i = numOfRotation; i > 0; i--)
            {
                arr[arrLength-i] = containerArr[containerArrPointer];
                containerArrPointer++;
            }

            return arr;
        }

        /// <summary>
        /// Rotate each element of the array 1 by 1
        /// Ex: arr[5] = {1, 2, 3, 4, 5} and numOfRotation = 2, then
        /// we do 1 by 1, so arr[5] = {2, 3, 4, 5, 1}, then 
        /// arr[5] = {3, 4, 5, 1, 2}
        /// Analysis:
        /// - Space: O(1). Extra 1 temp space to store the element to be rotated to the back of array
        /// - Time: 0(n*d). 2 loops to move each n-1 element forward d times.
        /// </summary>
        public int[] RotateArrayVersionTwo(int[] arr, int numOfRotation)
        {
            int arrLength = arr.Length;
            // i will point to the item to rotate
            for (int i = 0; i < numOfRotation; i++)
            {
                int temp = arr[0];
                // ii will point to item of array to move them 1 by 1 forward
                for (int ii = 1; ii < arrLength; ii++)
                {
                    arr[ii-1] = arr[ii];
                    
                }
                // Insert the item to rotate to back of array
                arr[arrLength - 1] = temp;
            }

            return arr;
        }

        /// <summary>
        /// Rotate the array by reversing the array.
        /// Ex: arr[5] = {1, 2, 3, 4, 5}, and we want to rotate 1 and 2 to back.
        /// First, we reverse the whole array so it becomes arr[5] = {5, 4, 3, 2, 1}.
        /// Now we noticed that the 2 items we need to rotate are already at the back of the array,
        /// so we will reverse those 2, and this gives arr[5] = {5, 4, 3, 1, 2}. 
        /// Next, we reverse the other elements to get correct order, so arr becomes
        /// arr[5] = {3, 4, 5, 1, 2}
        /// </summary>
        public int[] RotateArrayVersionThree(int[] arr, int numOfRotation)
        {
            int arrLength = arr.Length;
            // Reverse entire array
            arr = arr.ReverseArrary(0, arr.Length - 1);
            // Reverse the n number of elements to rotate at the back of array
            int startIndex = arrLength - numOfRotation;
            int endIndex = arrLength - 1;
            arr = arr.ReverseArrary(startIndex, endIndex);
            // Reverse the elements at the beginning of array
            endIndex = arrLength - numOfRotation - 1;
            arr = arr.ReverseArrary(0, endIndex);

            return arr;
        }
    }
}
