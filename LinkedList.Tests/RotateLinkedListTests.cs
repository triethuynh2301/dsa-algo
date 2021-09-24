using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LinkedList.Tests
{
    public class RotateLinkedListTests
    {
        [Fact]
        public void Rotate_IndexPosSmallerThanLength_ListRotate()
        {
            // arrange
            var test = new SLinkedList<int>();
            test.InsertAtEnd(15);
            test.InsertAtEnd(22);
            test.InsertAtEnd(8);
            test.InsertAtEnd(7);
            test.InsertAtEnd(14);
            test.InsertAtEnd(21);
            var actual = new SLinkedList<int>();
            actual.InsertAtEnd(8);
            actual.InsertAtEnd(7);
            actual.InsertAtEnd(14);
            actual.InsertAtEnd(21);
            actual.InsertAtEnd(15);
            actual.InsertAtEnd(22);

            // act
            RotateLinkedList<int>.Rotate(test, 4);

            // assert
            SLinkedList<int>.Node<int> fstPointer = test.head;
            SLinkedList<int>.Node<int> secPointer = actual.head;
            while(fstPointer != null)
            {
                Assert.Equal(fstPointer.data, secPointer.data);
                fstPointer = fstPointer.nextNode;
                secPointer = secPointer.nextNode;
            }
        }

        [Fact]
        public void Rotate_IndexPosLargerThanLength_ListRotate()
        {
            // arrange
            var test = new SLinkedList<int>();
            test.InsertAtEnd(1);
            test.InsertAtEnd(2);
            test.InsertAtEnd(3);
            test.InsertAtEnd(4);
            test.InsertAtEnd(5);
           
            var actual = new SLinkedList<int>();
            actual.InsertAtEnd(4);
            actual.InsertAtEnd(5);
            actual.InsertAtEnd(1);
            actual.InsertAtEnd(2);
            actual.InsertAtEnd(3);

            // act
            RotateLinkedList<int>.Rotate(test, 7);

            // assert
            SLinkedList<int>.Node<int> fstPointer = test.head;
            SLinkedList<int>.Node<int> secPointer = actual.head;
            while (fstPointer != null)
            {
                Assert.Equal(fstPointer.data, secPointer.data);
                fstPointer = fstPointer.nextNode;
                secPointer = secPointer.nextNode;
            }
        }

        [Fact]
        public void Rotate_IndexNeg_ListRotate()
        {
            // arrange
            var test = new SLinkedList<int>();
            test.InsertAtEnd(1);
            test.InsertAtEnd(2);
            test.InsertAtEnd(3);
            test.InsertAtEnd(4);
            test.InsertAtEnd(5);

            var actual = new SLinkedList<int>();
            actual.InsertAtEnd(3);
            actual.InsertAtEnd(4);
            actual.InsertAtEnd(5);
            actual.InsertAtEnd(1);
            actual.InsertAtEnd(2);

            // act
            RotateLinkedList<int>.Rotate(test, -2);

            // assert
            SLinkedList<int>.Node<int> fstPointer = test.head;
            SLinkedList<int>.Node<int> secPointer = actual.head;
            while (fstPointer != null)
            {
                Assert.Equal(fstPointer.data, secPointer.data);
                fstPointer = fstPointer.nextNode;
                secPointer = secPointer.nextNode;
            }
        }
    }
}
