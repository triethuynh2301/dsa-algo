//Given an array of size N containing only 0s, 1s, and 2s; sort the array in ascending order.

//Example 1:

//Input:
//N = 5
//arr[]= { 0 2 1 2 0}
//Output:
//0 0 1 2 2
//Explanation:
//0s 1s and 2s are segregated 
//into ascending order.
//Example 2:

//Input:
//N = 3
//arr[] = { 0 1 0}
//Output:
//0 0 1
//Explanation:
//0s 1s and 2s are segregated 
//into ascending order.

//Your Task:
//You don't need to read input or print anything. Your task is to complete the function sort012() that takes an array arr and N as input parameters and sorts the array in-place.

//Expected Time Complexity: O(N)
//Expected Auxiliary Space: O(1)

//Constraints:
//1 <= N <= 10 ^ 6
//0 <= A[i] <= 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class SortArrOf012
    {
        /// <summary>
        /// Sort the array containing 0s, 1s, 2s in ascending order
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="arr">Array to sort</param>
        /// <param name="n">Size of the arr</param>
        public void Sort012(int[] arr, int n)
        {
            int count0s = 0;
            int count1s = 0;
            int count2s = 0;

            // count the occurences of 0, 1, 2
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 0)
                {
                    count0s++;
                }
                else if (arr[i] == 1)
                {
                    count1s++;
                }
                else
                {
                    count2s++;
                }
            }

            int arrIndex = 0;
            while (count0s != 0)
            {
                arr[arrIndex] = 0;
                arrIndex++;
                count0s--;
            };

            while (count1s != 0)
            {
                arr[arrIndex] = 1;
                arrIndex++;
                count1s--;
            };

            while (count2s != 0)
            {
                arr[arrIndex] = 2;
                arrIndex++;
                count2s--;
            };
        }
    }
}
