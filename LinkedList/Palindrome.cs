using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class Palindrome<T>
    {
        /// <summary>
        /// Check to see if list is palindrome
        /// Time Complexity: O(n)
        /// </summary>
        /// <returns>True if list is palindrome</returns>
        public static bool IsPalindrome(LinkedList<T> list)
        {
            // if list is empty
            if (list.Count == 0)
            {
                return true;
            }

            LinkedListNode<T> front = list.First;
            LinkedListNode<T> back = list.Last;

            while(front != back)
            {
                if (!front.Value.Equals(back.Value))
                {
                    return false;
                }
                front = front.Next;
                back = back.Previous;
            }

            return true;
        }
    }
}
