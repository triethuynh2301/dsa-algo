//Given an unsorted array A of size N that contains only non-negative integers, find a continuous sub-array which adds to a given number S.

//Example 1:
//Input:
//N = 5, S = 12
//A[] = { 1,2,3,7,5}
//Output: 2 4
//Explanation: The sum of elements 
//from 2nd position to 4th position 
//is 12.

//Example 2:
//Input:
//N = 10, S = 15
//A[] = { 1,2,3,4,5,6,7,8,9,10}
//Output: 1 5
//Explanation: The sum of elements 
//from 1st position to 5th position
//is 15.
 
//Your Task:
//You don't need to read input or print anything. The task is to complete the function subarraySum() which takes arr, N and S as input parameters and returns a list containing the starting and ending positions of the first such occurring subarray from the left where sum equals to S. The two indexes in the list should be according to 1-based indexing. If no such subarray is found, return an array consisting only one element that is -1.

//Expected Time Complexity: O(N)
//Expected Auxiliary Space: O(1)

//Constraints:
//1 <= N <= 105
//1 <= Ai <= 1010

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class SubarrayWithGivenSum
    {
        /// <param name="arr">The given array</param>
        /// <param name="n">Size of the given array</param>
        /// <param name="s">The given sum</param>
        /// <returns>
        /// List containing starting and ending position according
        /// to 1-based indexing
        /// </returns>
        public List<int> SubarraySumMethodOne(int[] arr, int n, int s)
        {
            List<int> subarrayLists = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int currentSum = 0;
                for (int ii = i; ii < n; ii++)
                {
                    currentSum += arr[ii];
                    if (currentSum == s)
                    {
                        subarrayLists.Add(i + 1);
                        subarrayLists.Add(ii + 1);
                        return subarrayLists;
                    }
                    else if (currentSum > s)
                    {
                        break;
                    }
                }
            }

            subarrayLists.Add(-1);
            return subarrayLists;
        }

        /// <summary>
        /// Using sliding window techniques
        /// https://www.geeksforgeeks.org/find-subarray-with-given-sum/
        /// </summary>
        /// <param name="arr">The given array</param>
        /// <param name="n">Size of the given array</param>
        /// <param name="s">The given sum</param>
        /// <returns>
        /// List containing starting and ending position according
        /// to 1-based indexing
        /// </returns>
        public List<int> SubarraySumMethodTwo(int[] arr, int n, int s)
        {
            List<int> subarrSum = new List<int>();
            int arrSum = 0;

            for (int i = 1; i <= n; i++)
            {
                subarrSum.Add(i);
                arrSum += arr[i - 1];

                while (arrSum > s)
                {
                    arrSum -= arr[subarrSum[0] - 1];
                    subarrSum.RemoveAt(0);
                }

                if (arrSum == s)
                {
                    return new List<int>() { subarrSum[0], subarrSum[subarrSum.Count - 1] };
                }
            }
                subarrSum.Clear();
                subarrSum.Add(-1);
                return subarrSum;
        }
    }
}
