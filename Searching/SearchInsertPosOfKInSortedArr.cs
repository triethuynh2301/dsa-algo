//Given a sorted array Arr[](0 - index based) consisting of N distinct integers and an integer k, the task is to find the index of k, if it’s present in the array Arr[]. Otherwise, find the index where k must be inserted to keep the array sorted.


//Example 1:

//Input:
//N = 4
//Arr = { 1 , 3, 5, 6}
//k = 5
//Output: 2
//Explaination: Since 5 is found at index 2
//as arr[2] = 5, the output is 2.

//Example 2:

//Input:
//N = 4
//Arr = { 1, 3, 5, 6}
//k = 2
//Output: 1
//Explaination: Since 2 is not present in 
//the array but can be inserted at index 1 
//to make the array sorted.

//Your Task:
//You don't need to read input or print anything. Your task is to complete the function searchInsertK() which takes the array Arr[] and its size N and k as input parameters and returns the index.


//Expected Time Complexity: O(logN)
//Expected Auxiliary Space: O(1)


//Constraints:
//1 ≤ N ≤ 104
//- 103 ≤ Arr[i] ≤ 103
// - 103 ≤ k ≤ 103

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class SearchInsertPosOfKInSortedArray
    {
        /// <summary>
        /// Find the index of k in a[], if it is present. Otherwise, find
        /// the index where k must be inserted into a[] to keep it sorted.
        /// </summary>
        /// <param name="a">Array</param>
        /// <param name="N">Size of the array</param>
        /// <param name="k">The element to search or insert into the element
        /// if not found</param>
        /// <returns>The index of the seach element in the array or the index
        /// to insert into if element does not exist</returns>
        public int SearchInsertK(int[] a, int N, int k)
        {
            int leftIndex = 0;
            int rightIndex = N - 1;
            while (leftIndex <= rightIndex)
            {
                // middleIndex will be rounded up
                int middleIndex = (leftIndex + rightIndex) / 2;
                if (a[middleIndex] == k)
                {
                    return middleIndex;
                }
                // k is in the left side
                else if (a[middleIndex] > k)
                {
                    rightIndex = middleIndex - 1;
                }
                // k is in the right side
                else
                {
                    leftIndex = middleIndex + 1;
                }
            }

            return leftIndex;
        }

    }
}
