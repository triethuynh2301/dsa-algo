// LeetCode: https://tinyurl.com/pamb48h
// Educative: https://tinyurl.com/yhxhzdzv

using System.Collections.Generic;

namespace LinkedList
{
    public static class AddTwoNumbers
    {
        public static LinkedList<int> AddTwoIntegers(LinkedList<int> fstNo, LinkedList<int> secNo)
        {
            LinkedList<int> sum = new LinkedList<int>();
            int carry = 0;
            LinkedListNode<int> fst = fstNo.First;
            LinkedListNode<int> sec = secNo.First;
            int digitSum = 0;

            while (fst != null && sec != null)
            {
                digitSum = fst.Value + sec.Value + carry;
                if (digitSum < 10)
                {
                    carry = 0;
                    sum.AddLast(digitSum);
                }
                else
                {
                    carry = 1;
                    sum.AddLast(GetLastDigit(digitSum));
                }

                fst = fst.Next;
                sec = sec.Next;
            }

            // if first list is longer than second
            while (fst != null)
            {
                digitSum = fst.Value + carry;
                if (digitSum < 10)
                {
                    carry = 0;
                    sum.AddLast(digitSum);
                }
                else
                {
                    carry = 1;
                    sum.AddLast(GetLastDigit(digitSum));
                }

                fst = fst.Next;
            }

            // if second list is longer than first
            while (sec != null)
            {
                digitSum = sec.Value + carry;
                if (digitSum < 10)
                {
                    carry = 0;
                    sum.AddLast(digitSum);
                }
                else
                {
                    carry = 1;
                    sum.AddLast(GetLastDigit(digitSum));
                }

                sec = sec.Next;
            }

            // if there is a carry left
            if (carry != 0)
            {
                sum.AddLast(carry);
            }
            

            return sum;
        }

        public static int GetLastDigit(int num)
        {
            return num % 10;
        }
    }
}