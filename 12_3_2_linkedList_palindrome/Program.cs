public class Program
{
    static void Main(string[] args)
    {
        Solution mysol = new();
        Console.WriteLine(mysol.IsPalindrome(new ListNode(val: 1, (new ListNode(val: 2, null)))).ToString());
        Console.WriteLine(mysol.IsPalindrome(new ListNode(val: 1, (new ListNode(val: 2, new ListNode(val: 1, null))))).ToString());
        Console.WriteLine(mysol.IsPalindrome(new ListNode(val: 1, (new ListNode(val: 2, new ListNode(val: 2, new ListNode(val: 1, null)))))).ToString());

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
    public bool IsPalindrome(ListNode head)
    {
        if (head == null)
            return true;

        // figure out halfway point
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        // slow now points at halfway point
        // Console.WriteLine("fast is at " + (fast != null ? fast.val.ToString() : "null"));
        // Console.WriteLine("slow is at " + (slow != null ? slow.val.ToString() : "null"));

        // reverse linked list from halfway point to end (r = list from end to halfway point)
        ListNode r = ReverseList(slow);

        if (head.val != r.val)
            return false;
        while ((head.next != null) && (r.next != null))
        {
            head = head.next;
            r = r.next;
            if (head.val != r.val)
                return false;
        }
        return true;




        // ListNode l = new();
        // l = head;

        // // create stack with elements in linked list
        // Stack<int> s = new();
        // s.Push(l.val);
        // Console.Write(l.val + " ");
        // while (l.next != null){
        //     l = l.next;
        //     s.Push(l.val);
        //     Console.Write(l.val + " ");
        // }
        // Console.WriteLine();

        // // create stack with elements in linked list
        // Stack<int> s = new();
        // s.Push(l.val);
        // Console.Write(l.val + " ");
        // while (l.next != null){
        //     l = l.next;
        //     s.Push(l.val);
        //     Console.Write(l.val + " ");
        // }
        // Console.WriteLine();




        // l = ReverseList(head, out int size);
        // int halfSize = size/2;
        // Console.WriteLine($"halfSize is {halfSize}");

        // while ( -- > 0) {
        //     var first = l.val;
        //     var second = s.Peek();
        //     Console.WriteLine($"at {halfSize} comparing {first} and {second}.");
        //     if (l.val != s.Pop())
        //     {
        //         Console.WriteLine("not palindrome");
        //         return false;
        //     }
        //     l = l.next;
        // }
        // return true;

        ///////

        // Console.WriteLine($"{h}. {revList.val}~{head.val}");
        // if (revList.val != head.val)
        //     return false;
        // h--;

        // while ((head.next != null) && (revList.next != null)) {
        //     Console.Write("test:  ");
        //     revList = revList.next;
        //     head = head.next;
        //     if (h-- < 0)
        //         return true;
        //     Console.WriteLine($"{h}. {revList.val}~{head.val}");
        //     if (revList.val != head.val)
        //         return false;
        // }
        // return true;


        // go halfway into linked list, by going all the way then removing half
        // add elements to stack
        // int size = 0;
        // Stack<char>
        // ListNode l = head;
        // while (l.next != null {

        // })            
        //
    }

    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode cur = head;
        ListNode next = null;

        while (cur != null)
        {
            // save the next node so we don't lose the link
            next = cur.next;
            // reverse the pointer direction
            cur.next = prev;

            // move prev one step forward
            prev = cur;
            // move current one step forward
            cur = next;
        }
        return prev;
    }
}