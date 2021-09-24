//Given the head node of a singly linked list and an integer n, rotate the linked list by n.
//Note that the value of n can be larger than the length of linked list.
// Ex 1:
// Input: list = 1, 2, 3, 4, 5 and n = 2 or 7
// Output: list = 4, 5, 1, 2, 3
// Ex 2:
// Input: list = 1, 2, 3, 4, 5 and n = -2 or 3
// Output: list = 3, 4, 5, 1, 2


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public static class RotateLinkedList<T>
    {
        /// <summary>
        /// Rotate the linked list by n element
        /// Solution: 
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        public static void Rotate(SLinkedList<T> list, int n)
        {
            // find index of node to rotate
            int rotateIndex = 0;

            if (n < 0)
            {
                n = list.size + n;
            }
            rotateIndex = list.size - (n % list.size) - 1;

            // rotate 
            SLinkedList<T>.Node<T> last = list.head;
            while (last.nextNode != null)
            {
                last = last.nextNode;
            }
            last.nextNode = list.head;

            SLinkedList<T>.Node<T> current = list.head;
            while (rotateIndex > 0)
            {
                rotateIndex--;
                current = current.nextNode;
            }
            list.head = current.nextNode;
            current.nextNode = null;
           
        }
    }
}
