//Given an array A of N elements. Find the majority element in the array. A majority element in an array A of size N is an element that appears more than N/2 times in the array.
 

//Example 1:

//Input:
//N = 3
//A[] = { 1,2,3}
//Output:
//-1
//Explanation:
//Since, each element in 
//{1,2,3} appears only once so there 
//is no majority element.
//Example 2:

//Input:
//N = 5
//A[] = { 3,1,3,3,2}
//Output:
//3
//Explanation:
//Since, 3 is present more
//than N/2 times, so it is 
//the majority element.

//Your Task:
//The task is to complete the function majorityElement() which returns the majority element in the array. If no majority exists, return -1.
 

//Expected Time Complexity: O(N).
//Expected Auxiliary Space: O(1).


//Constraints:
//1 ≤ N ≤ 107
//0 ≤ Ai ≤ 106

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class MajorityElement
    {
        /// <summary>
        /// Find the major element in the array where the major element appears more than
        /// N/2 times in the array.
        /// Method 1: Iterate the array and count their occurrences
        /// Time complexity: O(n^2)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="a">The array in which to find the major element</param>
        /// <param name="size">Size of the array</param>
        /// <returns>The majority element of the array</returns>
        public int MajorityElementMethodOne(int[] a, int size)
        {
            int halfAppearTime = size / 2;

            for (int i = 0; i < size; i++)
            {
                int count = 0;
                for (int ii = i; ii < size; ii++)
                {
                    if (a[i] == a[ii])
                    {
                        count++;
                        if (count > halfAppearTime)
                        {
                            return a[i];
                        }
                    }
                }
            }

            return -1;
        }

        /// <summary>
        /// Find the major element in the array where the major element appears more than
        /// N/2 times in the array.
        /// Method 2: Use dictionary
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// </summary>
        /// <param name="a">The array in which to find the major element</param>
        /// <param name="size">Size of the array</param>
        /// <returns>The majority element of the array</returns>
        public int MajorityElementMethodTwo(int[] a, int size)
        {
            Dictionary<int, int> valueOccurrencesPair = new Dictionary<int, int>();
            int halfAppearTime = size / 2;

            // initialize the dictionary with values from arr
            foreach (var i in a)
            {
                if (!valueOccurrencesPair.ContainsKey(i))
                {
                    valueOccurrencesPair.Add(i, 0);
                }
            }

            // update the occurrences of the key in dictionary
            for (int i = 0; i < size; i++)
            {
                if (valueOccurrencesPair.ContainsKey(a[i]))
                {
                    valueOccurrencesPair[a[i]] += 1;
                }
            }

            // check to see if major element exists
            foreach (var i in valueOccurrencesPair)
            {
                if (i.Value > halfAppearTime)
                {
                    return i.Key;
                }
            }

            return -1;
        }

        /// <summary>
        /// Find the major element in the array where the major element appears more than
        /// N/2 times in the array.
        /// Method 2: Use sorting to make duplicates item adjacent and count them
        /// Time complexity: O(nlogn) (the time complexity for sorting)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="a">The array in which to find the major element</param>
        /// <param name="size">Size of the array</param>
        /// <returns>The majority element of the array</returns>
        public int MajorityElementMethodThree(int[] a, int size)
        {
            int halfAppearTime = size / 2;
            if (a.Length == 1)
            {
                return a[0];
            }

            // sort the array (O(nlogn) time complexity)
            Array.Sort(a);

            // count the occurrences
            int count = 1;
            for (int i = 1; i < size; i++)
            {
                // increase the count if adjacent value is equal
                if (a[i-1] == a[i])
                {
                    count++;
                    if (count > halfAppearTime)
                    { return a[i]; }
                } // reset count if next value is not
                else
                {
                    count = 1;
                }
            }

            return -1;
        }
    }
}
