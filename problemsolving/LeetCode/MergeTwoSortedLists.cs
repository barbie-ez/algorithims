using System;
namespace problemsolving.LeetCode
{
    public class ListNode
    {
       public int val;
       public ListNode next;
       public ListNode(int x) { val = x; }
    }

    public class MergeTwoSortedLists
    {
        public MergeTwoSortedLists()
        {
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 ==null && l2 == null)
            {
                return null;
            }

            int val1 = 0;
            int val2 = 0;

            if (l1 == null)
            {
                val1 = int.MaxValue;
            }
            else
            {
                val1 = l1.val;
            }
            if (l2 == null)
            {
                val2 = int.MaxValue;
            }
            else
            {
                val2 = l2.val;
            }
            ListNode node = new ListNode(0);
            
            ListNode final;

            if (val1 <= val2)
            {
                final = new ListNode(val1);
                l1 = l1.next;
            }
            else
            {
                final = new ListNode(val2);
                l2 = l2.next;
            }

            node.next = final;

            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    val1 = int.MaxValue;
                }
                else
                {
                    val1 = l1.val;
                }
                if (l2 == null)
                {
                    val2 = int.MaxValue;
                }
                else
                {
                    val2 = l2.val;
                }

                if (val1 <= val2)
                {
                    final.next = new ListNode(val1);
                    final = final.next;
                    l1 = l1.next;
                }
                else
                {
                    final.next = new ListNode(val2);
                    final = final.next;
                    l2 = l2.next;
                }
            }
            return node.next;
        }
    }
}
