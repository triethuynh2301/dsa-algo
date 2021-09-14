using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LinkedList
{
    public class SLinkedList<T>
    {
        #region Node class
        public class Node<T>
        {
            public T data;
            public Node<T> nextNode;

            public Node(T value)
            {
                data = value;
                nextNode = null;
            }
        }
        #endregion

        #region properties and constructors
        // head node of the linked list
        public Node<T> head;
        // size of the LL
        public int size;

        /// <summary>
        /// Initialize the linked list when first created
        /// The head node should be empty
        /// </summary>
        public SLinkedList()
        {
            head = null;
            size = 0;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Reverse the list
        /// </summary>
        public void Reverse()
        {
            Node<T> previous = null;
            Node<T> current = head;
            Node<T> next = null;
            // reverse the link between current node and previous node
            // while traversing the list
            while(current != null)
            {
                next = current.nextNode;
                current.nextNode = previous;
                previous = current;
                current = next;
            }
            head = previous;
        }
        /// <summary>
        /// Count number of nodes in list
        /// </summary>
        public int Length()
        {
            Node<T> last = head;
            int nodeCounts = 0;
            while(last != null)
            {
                last = last.nextNode;
                nodeCounts++;
            }

            return nodeCounts;
        }

        /// <summary>
        /// Delete ALL nodes with corresponding value from list
        /// <param name="data">Value to delete</param>
        /// </summary>
        public void DeleteByValue(T data)
        {
            Node<T> currentNode = head;
            Node<T> nextNode;

            // value to delete is first node
            if (currentNode.data.Equals(data))
            {
                DeleteAtHead();
            }

            // search for the node and delete
            while(currentNode.nextNode != null)
            {
                nextNode = currentNode.nextNode;
                if (nextNode.data.Equals(data))
                {
                    currentNode.nextNode = nextNode.nextNode;
                    nextNode = null;
                    size--;
                }
                else
                {
                    currentNode = currentNode.nextNode;
                }
            }
        }

        /// <summary>
        /// Delete the first node in list
        /// </summary>
        public void DeleteAtHead()
        {
            Node<T> temp = head;
            head = temp.nextNode;
            temp = null;
            size--;
        }

        /// <summary>
        /// Search singly LL for a value
        /// </summary>
        /// <param name="data">Search value</param>
        /// <returns>True if value is found</returns>
        public bool SearchNode(T data)
        {
            Node<T> currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.data.Equals(data))
                {
                    return true;
                }
                currentNode = currentNode.nextNode;
            } 

            return false;
        }

        /// <summary>
        /// Insert value to beginning of single LL
        /// </summary>
        /// <param name="data"></param>
        public void InsertAtHead(T data)
        {
            // create new node
            Node<T> newNode = new Node<T>(data);
            // link new node to current head node
            newNode.nextNode = head;
            // new node becomes head
            head = newNode;
            size++;
        }

        /// <summary>
        /// Insert value to the end of the singly LL
        /// </summary>
        /// <param name="data">Value to inserted</param>
        public void InsertAtEnd(T data)
        {
            // if LL is empty, insert at head
            if (IsEmpty())
            {
                InsertAtHead(data);
            }
            // else, traverse to end to insert
            else
            {
                // create the new node
                Node<T> newNode = new Node<T>(data);
                Node<T> temp = head;
                // traverse to the end node of list
                while (temp.nextNode != null)
                {
                    temp = temp.nextNode;
                }
                // attach new node to the end of list
                temp.nextNode = newNode;
                size++;
            }
        }

        /// <summary>
        /// Check to see if the list is empty
        /// </summary>
        /// <returns>True if list is empty</returns>
        public bool IsEmpty()
        {
            if (head == null) return true;
            return false;
        }

        /// <summary>
        /// Print data of every node in the list
        /// </summary>
        public void PrintList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return;
            }

            Node<T> temp = head;
            Console.WriteLine("List : ");
            while (temp.nextNode != null)
            {
                Console.Write(temp.data.ToString() + " -> ");
                temp = temp.nextNode;
            }
            Console.WriteLine(temp.data.ToString() + " -> null");
            Console.WriteLine($"Array size is {size}.");
            Console.WriteLine($"Array size is {this.Length()}.");
        }
        #endregion
    }
}
