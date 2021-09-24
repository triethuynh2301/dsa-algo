using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class IntersectionPointTwoLists<T>
    {
        /// <summary>
        /// Find the first point of intersection of 2 list
        /// </summary>
        /// Solution 1: Use brute-force 
        /// Time complexity: O(n^2)
        /// Space complexity: O(1)
        /// <returns>First point of intersection if 2 lists intersect or null</returns>
        public static SLinkedList<T>.Node<T> FindIntersectionNodeI(SLinkedList<T> list1, SLinkedList<T> list2)
        {
            SLinkedList<T>.Node<T> fstPointer = list1.head;
            
            while (fstPointer != null)
            {
                SLinkedList<T>.Node<T> secPointer = list2.head;
                while (secPointer != null)
                {
                    if (fstPointer == secPointer)
                    {
                        return fstPointer;
                    }
                    secPointer = secPointer.nextNode;
                }
                
                fstPointer = fstPointer.nextNode;
            }

            return null;
        }

        /// <summary>
        /// Find the first point of intersection of 2 list
        /// </summary>
        /// Solution 2: Use hashing
        /// Time complexity: O(n)
        /// Space complexity: O(n)
        /// <returns>First point of intersection if 2 lists intersect or null</returns>
        public static SLinkedList<T>.Node<T> FindIntersectionNodeII(SLinkedList<T> fstList, SLinkedList<T> secList)
        {
            SLinkedList<T>.Node<T> current = fstList.head;
            HashSet<SLinkedList<T>.Node<T>> nodeSet = new HashSet<SLinkedList<T>.Node<T>>();

            // add all nodes of first list to a set
            while (current != null)
            {
                nodeSet.Add(current);
                current = current.nextNode;
            }

            // traverse second list and check match 
            current = secList.head;
            while(current != null)
            {
                if (nodeSet.Contains(current))
                {
                    return current;
                }

                current = current.nextNode;
            }

            return null;
        }

        /// <summary>
        /// Find the first point of intersection of 2 list
        /// </summary>
        /// Solution 3: Using difference of node counts
        /// 1) Get node counts of first list
        /// 2) Get node counts of second list
        /// 3) Calculate the difference d
        /// 4) In the longer list, move pointer d steps, now both lists have same length (longer list starts at d step)
        /// 5) Start comparing each node in both list while traversing
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// <returns>First point of intersection if 2 lists intersect or null</returns>
        public static object FindIntersectionNodeIII(SLinkedList<int> fstList, SLinkedList<int> secList)
        {
            SLinkedList<int>.Node<int> currPointer = null;
            SLinkedList<int>.Node<int> otherPointer = null;
            int lengthDiff = Math.Abs(fstList.size - secList.size);

            if (fstList.size >= secList.size)
            {
                // move d steps in longer list
                currPointer = fstList.head;
                while(lengthDiff > 0)
                {
                    lengthDiff--;
                    currPointer = currPointer.nextNode;
                }
                // traverse both lists and check
                otherPointer = secList.head;
                while (currPointer != null)
                {
                    if (currPointer == otherPointer)
                    {
                        return currPointer;
                    }
                    currPointer = currPointer.nextNode;
                    otherPointer = otherPointer.nextNode;
                }
            }
            else
            {
                currPointer = secList.head;
                while (lengthDiff > 0)
                {
                    lengthDiff--;
                    currPointer = currPointer.nextNode;
                }
                otherPointer = fstList.head;
                while (currPointer != null)
                {
                    if (currPointer == otherPointer)
                    {
                        return currPointer;
                    }
                    currPointer = currPointer.nextNode;
                    otherPointer = otherPointer.nextNode;
                }
            }

            return null;
        }
    }
}
