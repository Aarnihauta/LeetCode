namespace TrueLeetCode.Leetcode;
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        string str = val.ToString() + " ";
        if (next != null)
        {
            str += next.ToString();
        }

        return str;
    }

    public static ListNode Create(params int[] vals)
    {
        var head = new ListNode();
        var current = head;
        for (int i = 0; i < vals.Length; i++)
        {
            current.val = vals[i];
            if(i < vals.Length - 1)
            {
                current.next = new ListNode();
                current = current.next;
            }
        }

        return head;
    }
}