using System;

namespace _2._Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListNode l1Head = null;
            ListNode l1currect = null;
            ListNode prev = null;
            l1currect = new ListNode(9);
            l1Head = l1currect;
            l1currect.next = new ListNode(9);
            l1currect = l1currect.next;
            l1currect.next = new ListNode(9);
            l1currect = l1currect.next;
            l1currect.next = new ListNode(9);
            l1currect = l1currect.next;
            l1currect.next = new ListNode(9);
            l1currect = l1currect.next;
            l1currect.next = new ListNode(9);
            l1currect = l1currect.next;
            l1currect.next = new ListNode(9);
            l1currect = l1currect.next;

            ListNode l2Head = null;
            ListNode l2currect = null;
            l2currect = new ListNode(9);
            l2Head = l2currect;
            l2currect.next = new ListNode(9);
            l2currect = l2currect.next;
            l2currect.next = new ListNode(9);
            l2currect = l2currect.next;
            l2currect.next = new ListNode(9);
            l2currect = l2currect.next;

            new Solution().AddTwoNumbers(l1Head, l2Head);
        }
    }
    public class ListNode
    {
          public int val;
          public ListNode next;
          public ListNode(int val = 0, ListNode next = null)
          {
                this.val = val;
                this.next = next;
          }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode lrHead = null;
            ListNode current = null;

            while(l1!=null && l2!=null)
            {
                int a = l1.val + l2.val + carry;
                if (lrHead == null) current = new ListNode(a % 10);
                else
                {
                    current.next = new ListNode(a % 10);
                    current = current.next;
                }
                carry = a / 10;
                if (lrHead == null) lrHead = current;
                l1 = l1.next;
                l2 = l2.next;
                //
            }
            while (l1 != null)
            {
                int a = l1.val + carry;
                if (lrHead == null) current = new ListNode(a % 10);
                else
                {
                    current.next = new ListNode(a % 10);
                    current = current.next;
                }
                carry = a / 10;
                if (lrHead == null) lrHead = current;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                int a = l2.val + carry;
                if (lrHead == null) current = new ListNode(a % 10);
                else
                {
                    current.next = new ListNode(a % 10);
                    current = current.next;
                }
                carry = a / 10;
                if (lrHead == null) lrHead = current;
                l2 = l2.next;
            }
            if(carry!=0)
            {
                int a = carry;
                if (lrHead == null) current = new ListNode(a % 10);
                else
                {
                    current.next = new ListNode(a % 10);
                    current = current.next;
                }
                carry = a / 10;
                if (lrHead == null) lrHead = current;
            }
            return lrHead;
        }
    }
}
