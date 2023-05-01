namespace TrueLeetCode.Leetcode.LinkedList;

//https://leetcode.com/problems/design-hashset
public class MyHashSet
{
    private List<int>[] _table = new List<int>[7];
    public int Count { get; set; }
    public void Add(int item)
    {
        int entry = GetEntry(item);
        var list = _table[entry] ??= new List<int>();

        if (list.Contains(item))
            return;

        if(Count == _table.Length)
        {
            Array.Resize(ref _table, Count * 2 - 1);
        }

        Count++;
        list.Add(item);
    }

    public void Remove(int item)
    {
        int entry = GetEntry(item);
        var list = _table[entry] ??= new List<int>();

        if (!list.Contains(item))
            return;

        Count--;
        list.Remove(item);
    }

    public bool Contains(int item) => _table[GetEntry(item)]?.Contains(item) ?? false;

    private int GetEntry(int item)
    {
        return item.GetHashCode() % _table.Length;
    }

    private void Resize()
    {

    }
}