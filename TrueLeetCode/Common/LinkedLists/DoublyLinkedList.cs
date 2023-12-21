using System.Text;

namespace TrueLeetCode.DataStructure.LinkedLists;
public class DoublyLinkedList<T>
{
    public DoublyLinkedListNode<T> Head { get; set; }
    public void InsertFirst(T value)
    {
        if (Head == null)
        {
            Head = new DoublyLinkedListNode<T>(value);
        }
        else
        {
            var node = new DoublyLinkedListNode<T>(value);
            node.Next = Head;
            Head.Previous = node;
            Head = node;
        }
    }

    public void InsertLast(T value)
    {
        var current = Head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        var node = new DoublyLinkedListNode<T>(value);
        node.Previous = current;
        current.Next = node;
    }

    public void DeleteFirst()
    {
        if (Head == null)
        {
            return;
        }

        Head = Head.Next;
        Head.Previous = null;
    }

    public void DeleteLast()
    {
        if (Head == null)
        {
            return;
        }
        var current = Head;

        while (current.Next?.Next != null)
        {
            current = current.Next;
        }

        current.Next = null;
    }

    public void Delete(T value)
    {
        var current = Head;

        while (current.Next != null && !current.Value.Equals(value))
        {
            current = current.Next;
        }
        if (current == Head)
        {
            DeleteFirst();
        }
        else
        {
            current.Previous.Next = current.Next;
            if (current.Next != null)
            {
                current.Next.Previous = current.Previous;
            }
        }
    }

    public bool IsEmpy() => Head == null;

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
            sb.Append("<->");
            curr = curr.Next;
        }
        sb.Remove(sb.Length - 3, 3);
        Console.WriteLine(sb);
    }

    public void DrawReverse()
    {
        if (Head == null)
        {
            return;
        }

        var curr = Head;
        var list = new Stack<T>();
        while (curr != null)
        {
            if (curr != null)
            {
                list.Push(curr.Value);
            }
            curr = curr.Next;
        }
        StringBuilder sb = new StringBuilder();
        foreach (var item in list)
        {
        }
        sb.Remove(sb.Length - 3, 3);
        Console.WriteLine(sb);
    }
}

public class DoublyLinkedListNode<T>
{
    public T Value;

    public DoublyLinkedListNode(T value)
    {
        Value = value;
    }

    public DoublyLinkedListNode<T> Previous { get; set; }
    public DoublyLinkedListNode<T> Next { get; set; }

    public override string ToString()
    {
        return Value.ToString();
    }
}
