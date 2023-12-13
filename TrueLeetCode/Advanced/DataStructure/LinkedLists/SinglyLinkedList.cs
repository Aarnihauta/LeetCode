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
    }

    public void Insert(SinglyLinkedListNode node, int value)
    {

    }

    //O(n)
    public void Remove(SinglyLinkedListNode node)
    {
        if(node == Head)
        {
            Head = Head.Next;
        }
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