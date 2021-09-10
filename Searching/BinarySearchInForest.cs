//There are n trees in a forest. The heights of the trees is stored in array tree[], where tree[i] denotes the height of the ith tree in the forest. If the ith tree is cut at a height H, then the wood collected is tree[i] -H, provided tree[i] > H. If the total woods that needs to be collected is exactly equal to k, find the height H at which every tree should be cut (all trees have to be cut at the same height). If it is not possible then return -1 else return H.

//Example 1:

//Input:
//n = 5, k = 4
//nums[] = { 2, 3, 6, 2, 4}
//Output: 3
//Explanation: Wood collected by cutting trees
//at height 3 = 0 + 0 + (6-3) +0 + (4 - 3) = 4
//hence 3 is to be subtracted from all numbers.
//Since 2 is lesser than 3, nothing gets
//subtracted from it.
//Example 2:

//Input:
//n = 6, k = 8
//nums[] = { 1, 7, 6, 3, 4, 7}
//Output: 4
//Explanation: Wood collected by cutting trees
//at height 4 = 0+(7-4)+(6 - 4) + 0 + 0 + (7 - 4) = 8
//Your Task:
//Your task is to complete the function find_height(). This function takes the array tree[ ], and the integers n and k as input parameters and returns the height at which trees have to be cut. If no positive integer value of height is possible, return -1.


//Expected Time Complexity: O(n log h)
//Expected Auxiliary Space: O(1)


//Constraints:
//1 <= n <= 104
//1 <= tree[i] <= 103
//1 <= k <= 107

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class BinarySearchInForest
    {
        /// <summary>
        /// Find the tree height at which every tree should be cut at
        /// so that the amount of woord collected is equal to k. If not 
        /// found, then return to -1.
        /// Method 1: Brute force approach. Go from height 0 to max height,
        /// which is the height of highest tree and see which height will 
        /// help collect enough wood k.
        /// Time complexity: O(n^2) (maybe, n of first loop is the height of
        /// highest tree, not the size of tree array.
        /// Space complexity: O(1) 
        /// </summary>
        /// <param name="tree">Array containing tree height</param>
        /// <param name="n">Size of the tree height array</param>
        /// <param name="k">Wood to be collected</param>
        /// <returns>Return the height at which all trees need
        /// to cut at or -1 if not possible</returns>
        public int FindHeightMethodOne(int[] tree, int n, int k)
        {
            int maxHeight = tree.Max();

            for(int i = 0; i < maxHeight; i++)
            {
                if (SumWoodCollected(i, tree, n) == k)
                {
                    return i;
                }
            }
            
            return -1;
        }

        /// <summary>
        /// Find the tree height at which every tree should be cut at
        /// so that the amount of woord collected is equal to k. If not 
        /// found, then return to -1.
        /// Method 1: Brute force approach. Go from height 0 to max height,
        /// which is the height of highest tree and see which height will 
        /// help collect enough wood k.
        /// Time complexity: 
        /// Space complexity: 
        /// </summary>
        /// <param name="tree">Array containing tree height</param>
        /// <param name="n">Size of the tree height array</param>
        /// <param name="k">Wood to be collected</param>
        /// <returns>Return the height at which all trees need
        /// to cut at or -1 if not possible</returns>
        public int FindHeightMethodTwo(int[] tree, int n, int k)
        {
            // Sort the array so that the highest tree will be at the end.
            // This makes finding highest tree O(logn). Otherwise, finding 
            // the max height of tree will be O(N).
            Array.Sort(tree);
            int minHeight = 0;
            int maxHeight = tree[n - 1];

            while(minHeight <= maxHeight)
            {
                int midHeight = (minHeight + maxHeight) / 2;
                int woodCollectedAtMid = SumWoodCollected(midHeight, tree, n);
                if (woodCollectedAtMid == k)
                {
                    return midHeight;
                }
                // wood collected needs to decrease, height should increase
                else if (woodCollectedAtMid > k)
                {
                    minHeight = midHeight + 1;
                }
                // wood collected needs to increase, height should decrease
                else
                {
                    maxHeight = midHeight - 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Find the amount of wood collected at specified height
        /// </summary>
        /// <param name="height">The specified height to cut trees</param>
        /// <param name="tree">Array of trees height</param>
        /// <param name="n">Size of the array</param>
        /// <returns></returns>
        public int SumWoodCollected(int height, int[] tree, int n)
        {
            int woodCollected = 0;

            for (int i = 0; i < n; i++)
            {
                if (tree[i] > height)
                {
                    woodCollected += tree[i] - height;
                }
            }

            return woodCollected;
        }
    }
}
