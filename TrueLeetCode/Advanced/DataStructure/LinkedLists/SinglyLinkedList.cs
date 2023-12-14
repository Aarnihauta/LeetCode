using System.Text;

namespace TrueLeetCode.Advanced.DataStructure.LinkedLists;
public class SinglyLinkedList
{
    public SinglyLinkedList(SinglyLinkedListNode head)
    {
        Head = head;
        Tail = head;
    }

    public SinglyLinkedList(int value) : this(new SinglyLinkedListNode(value))
    {

    }
    public SinglyLinkedListNode Head { get; private set; }
    public SinglyLinkedListNode Tail { get; private set; }

    //O(1)
    public void InsertLast(int value)
    {
        Tail.Next = new SinglyLinkedListNode(value);
        Tail = Tail.Next;
    }

    public void Insert(SinglyLinkedListNode node, int value)
    {
        var parent = FindParent(node.Value);

        if (parent != null)
        {
            if (parent.Next == null)
            {
                parent.Next.Next = new SinglyLinkedListNode(value);
            }
            else
            {
                var temp = parent.Next.Next;
                parent.Next.Next = new SinglyLinkedListNode(value);
                parent.Next.Next.Next = temp;
            }
        }
    }

    //O(n)
    public void Remove(SinglyLinkedListNode node)
    {
        if (node == Head)
        {
            Head = Head.Next;
            return;
        }

        var head = Head;

        while(head?.Next != node)
        {
            head = head.Next;
        }

        if(head != null)
        {
            var temp = head.Next.Next;
            head.Next = temp;
        }
    }

    //O(n)
    public SinglyLinkedListNode Find(int value)
    {
        var head = Head;

        while (head != null && head != Tail && head.Value != value)
        {
            head = head.Next;
        }

        return head;
    }

    //O(n)
    public SinglyLinkedListNode FindParent(int value)
    {
        var head = Head;

        while (head != null && head != Tail && head.Next.Value != value)
        {
            head = head.Next;
        }

        return head;
    }

    //O(n)
    public void Draw()
    {
        var curr = Head;
        StringBuilder sb = new StringBuilder();
        while (curr != null)
        {
            sb.Append(curr.Value);
            sb.Append("->");
            curr = curr.Next;
        }
        sb.Remove(sb.Length - 2, 2);
        Console.WriteLine(sb);
    }
}

public class SinglyLinkedListNode
{
    public SinglyLinkedListNode(int value, SinglyLinkedListNode next = default)
    {
        Value = value;
        Next = next;
    }

    public int Value { get; set; }
    public SinglyLinkedListNode Next { get; set; }
}