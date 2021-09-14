using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class SLinkedListToolBox<T>
    {
        /// <summary>
        /// Detect if there is a loop in the list
        /// </summary>
        /// <param name="list">List to find loop in</param>
        /// <returns>True if loop exists</returns>
        public static bool DetectLoop(SLinkedList<T> list)
        {
            // use Floyd's cycle detection algorithm
            // with slow and fast pointer
            SLinkedList<T>.Node<T> slow = list.head;
            SLinkedList<T>.Node<T> fast = list.head;
            while(fast != null && fast.nextNode != null)
            {
                slow = slow.nextNode; // slow pointer moves 1 step
                fast = fast.nextNode.nextNode; // fast pointer moves 2 steps
                // if they ever meet, a loop exists
                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Find middle value of list 
        /// Method 1: Use size of list to find middle index
        /// </summary>
        /// <param name="list">List to inspect</param>
        /// <returns>Value of middle node</returns>
        public static T FindMiddleMethodOne(SLinkedList<T> list)
        {
            int midIndex = 0;
            if ((list.size % 2 == 0))
            {
                midIndex = (list.size / 2) - 1;
            }
            else
            {
                midIndex = (list.size / 2);
            }

            int currentIndex = 0;
            SLinkedList<T>.Node<T> current = list.head;
            while(currentIndex <= midIndex)
            {
                currentIndex++;
                current = current.nextNode;
                if (currentIndex == midIndex)
                {
                    break;
                }
            }

            return current.data;
        }

        /// <summary>
        /// Find middle value of list
        /// Method 2: Use 2 pointers to traverse the list
        /// Slow will jump 1 node while fast jumps 2 nodes, so
        /// fast will double the speed hence reaches end while
        /// slow will be at middle. 
        /// Time complexity: O(n)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="list">List to inspect</param>
        /// <returns>Null if empty or middle value</returns>
        public static Object FindMiddleMethodTwo(SLinkedList<T> list)
        {
            if (list.IsEmpty())
            {
                return null;
            }

            SLinkedList<T>.Node<T> slow = list.head;
            SLinkedList<T>.Node<T> fast = list.head;

            // traverse till fast reaches the end
            while (fast != null && fast.nextNode != null)
            {
                fast = fast.nextNode.nextNode;

                if (fast != null)
                {
                    slow = slow.nextNode;
                }
            }

            return slow.data;
        }

        /// <summary>
        /// Remove duplicates nodes from list
        /// </summary>
        public static void RemoveDuplicatesMethodOne(SLinkedList<T> list)
        {
            HashSet<T> nodeSet = new HashSet<T>();
            SLinkedList<T>.Node<T> current = list.head;
            SLinkedList<T>.Node<T> next = list.head;
            nodeSet.Add(current.data);

            while (current.nextNode != null)
            {
                next = current.nextNode;
                // add new value to set
                if (!nodeSet.Contains(next.data))
                {
                    nodeSet.Add(next.data);
                    current = current.nextNode;
                }
                // if value already exist, remove duplicates
                else
                {
                    current.nextNode = next.nextNode;
                    next = null;
                    list.size--;
                }
            }
        }
    }
}
