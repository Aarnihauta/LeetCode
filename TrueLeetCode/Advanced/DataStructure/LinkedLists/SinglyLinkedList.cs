using System.Text;

namespace TrueLeetCode.Advanced.DataStructure.LinkedLists;
public class SinglyLinkedList<T>
{
    public SinglyLinkedList(T value)
    {
        Head = new SinglyLinkedListNode<T>(value);
    }

    public SinglyLinkedListNode<T> Head { get; private set; }

    //O(1)
    public void InsertFirst(T value)
    {
        var node = new SinglyLinkedListNode<T>(value);

        node.Next = Head;
        Head = node;
    }

    //O(n)
    public void InsertLast(T value)
    {
        var node = new SinglyLinkedListNode<T>(value);

        if (Head == null)
        {
            Head = node;
        }
        else
        {
            var current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
        }
    }

    //O(1)
    public void DeleteFirst()
    {
        if (Head == null)
        {
            return;
        }

        Head = Head.Next;
    }

    //O(n)
    public void DeleteLast()
    {
        if (Head == null)
        {
            return;
        }

        var current = Head;

        while (current.Next.Next != null)
        {
            current = current.Next;
        }
        current.Next = null;
    }

    //O(n)
    public void Delete(T element)
    {
        if (Head == null)
        {
            return;
        }

        var current = Head;
        var prev = current;
        while (current != null && !current.Value.Equals(element))
        {
            prev = current;
            current = current.Next;
        }

        if (current == Head)
        {
            DeleteFirst();
        }
        else if (current != null)
        {
            prev.Next = current.Next;
        }
    }

    //O(1)
    public bool IsEmpty => Head == null;

    //O(1)
    public void Clear()
    {
        Head = null;
    }

    //O(n)
    public void Draw()
    {
        if (Head == null)
        {
            return;
        }

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

public class SinglyLinkedListNode<T>
{
    public SinglyLinkedListNode(T value, SinglyLinkedListNode<T> next = default)
    {
        Value = value;
        Next = next;
    }

    public T Value { get; set; }
    public SinglyLinkedListNode<T> Next { get; set; }
}