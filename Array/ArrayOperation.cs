using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public static class ArrayOperation
    {
        public static int Max(this List<int> numList)
        {
            int temp = numList[0];

            foreach(var i in numList)
            {
                if (temp < i)
                    temp = i;
            }

            return temp;
        }

        public static int Min(this List<int> numList)
        {
            int temp = numList[0];

            numList.ForEach(x =>
            {
                if (temp > x)
                    temp = x;
            });

            return temp;
        }

        /// <summary>
        /// Return the number of unique in the array k, and swap these
        /// unique elements to the front of the array
        /// </summary>
        /// <param name="arr">the input arr to remove duplicates from</param>
        /// <param name="n">size of the arr</param>
        /// <returns>return the number of unique elements in arr</returns>
        public static int RemoveDuplicates(this int[] arr)
        {
            //Using 2 pointer technique to scan the arr
            //1st pointer to traverse the array
            //2nd pointer used to remove the duplicates, and keep counts of unique elements
            //1) If arr[1st] = arr[2nd] meaning the duplicates streak is still going,
            //we keep traversing arr and do nothing(1st++)
            //2) Once arr[1st] != arr[2nd] => the duplicate streak ends, increment
            //the 2nd pointer and replace it with the new value of 1st pointer
            //3) Repeat the process till array traversal is done

            var n = arr.Length;
            int secondPointer = 0; // must be at least 1 unique element
            for (int firstPointer = 1; firstPointer < n; firstPointer++)
            {
                // the duplicate streak ends
                if (arr[firstPointer] != arr[secondPointer])
                {
                    secondPointer++;
                    arr[secondPointer] = arr[firstPointer];
                }
            }

            return secondPointer + 1;
        }

        /// <summary>
        /// Reverse subarray within an array from start index to end index
        /// Ex: Reverse of arr[5] = {1, 2, 3, 4, 5} is {5, 4, 3, 2 , 1}.
        /// We swap the start index and end index, so in the first step 
        /// arr[5] = {5, 2, 3, 4, 1}. We keep doing this step by increasing start index
        /// and decrease end index until those 2 are equal
        /// </summary>
        public static int[] ReverseArrary(this int[]arr, int startIndex, int endIndex)
        {
            int temp;
            while (startIndex < endIndex)
            {
                // swap place between start and end index
                temp = arr[startIndex];
                arr[startIndex] = arr[endIndex];
                arr[endIndex] = temp;

                startIndex++;
                endIndex--;
            }

            return arr;
        }
    }
}
