// 1. (#203)Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.


//Input: head = [1, 2, 6, 3, 4, 5, 6], val = 6

//Output: [1, 2, 3, 4, 5]

//Example 2:

//Input: head = [], val = 1

//Output: []

//Example 3:

//Input: head = [7, 7, 7, 7], val = 7

//Output: []

class program
{
    static void Main(string[] args)
    {
        Solution mysol = new();
        ListNode test1 = new ListNode(val: 1, next: (new ListNode(val: 2, next: (new ListNode(val: 3, next: (new ListNode(val: 6, next: (new ListNode(val: 4, next: (new ListNode(val: 5, next: (new ListNode(val: 6, next: null)))))))))))));
        mysol.RemoveElements(test1, 6);

        ListNode test2 = new();
        mysol.RemoveElements(test2, 7);

        ListNode test3 = new ListNode(val: 7, next: (new ListNode(val: 7, next: (new ListNode(val: 7, next: null)))));
        mysol.RemoveElements(test3, 7);
    }
}

// Definition for singly-linked list
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
    public ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null)
            return head;

        // print out linked list to see what's in it
        Console.Write("list is ");
        ListNode temp = head;
        Console.Write(temp.val + " ");
        while (temp.next != null)
        {
            Console.Write(temp.next.val + " ");
            temp = temp.next;
        }
        Console.WriteLine();

        //// define false start to simplify linked list operations
        //ListNode sentinel = new(val: 0, next: head);
        ////sentinel.val = 0;
        ////sentinel.next = head;

        //// iterate through list, removing middle element if value matches
        //ListNode cur = head;
        //ListNode prev = sentinel;

        ////Console.WriteLine("made it here without error");

        //while (cur.next != null)
        //{
        //    if (cur.val == val)
        //    {
        //        prev.next = cur.next; // remove by skipping cur node
        //    }

        //    prev = prev.next;
        //    cur = cur.next;
        //    //Console.WriteLine(" next cur val is " + cur.val);
        //}

        //---------------
        ListNode sentinel = new ListNode(0, head);
        ListNode prev = sentinel; 
        ListNode cur = head; 
        while (cur != null)
        {
            if (cur.val == val) // if found matching node
            {
                prev.next = cur.next; // remove cur; do NOT move prev
            }
            else 
            { 
                prev = cur; // only move prev when current is kept
            } 
            cur = cur.next; 
        }

        // final check and remove last element matches
        //if (cur.val == val)
        //    prev.next = null;

        // print out linked list to see what's in it
        ListNode newlink = new ListNode(0, sentinel.next);
        Console.Write("updated list is ");
        //Console.Write(newlink.val + " ");
        while (newlink.next != null)
        {
            Console.Write(newlink.next.val + " ");
            newlink = newlink.next;
        }
        Console.WriteLine();

        // final step return sentinel.next (which should now point to modified linked list)
        return sentinel.next;

        // if (p == null) // zero elements
        //     return p;


        // ListNode n = head.next;

        // if (n == null) // only one element
        // {
        //     if (head.val == val)
        //     {
        //         ListNode blankList = new();
        //         return blankList;
        //     }
        //     return head;
        // }

        // ListNode p = head;
        // if (p.val == val) {
        //     p = head.next
        // }

        // ListNode n = head.next;

        // while (n.next != null) {
        //     if head.val == 
        // }



        // if (head.next.next == null) // only two elements
        // {
        //     if (head.val == val)
        //     {
        //         head = head.next;    
        //     }

        //     if (head.val == val)
        //     {
        //         head = head.next;
        //     }
        // }

        // ListNode cur = head;
        // ListNode next = head.next;
        // while (next != null) {
        //     if (cur.val == val)
        //     {
        //         cur = next;
        //     }




            }


        }