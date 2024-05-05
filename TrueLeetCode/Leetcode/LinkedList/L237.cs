namespace TrueLeetCode.Leetcode.LinkedList;

//https://leetcode.com/problems/delete-node-in-a-linked-list
public class L237
{
    public void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}
