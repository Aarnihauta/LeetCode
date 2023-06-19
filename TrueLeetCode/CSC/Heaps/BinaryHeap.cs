namespace TrueLeetCode.CSC.Heap;
public class BinaryHeap
{
    private List<int> _items;
    public int Count => _items.Count;

    public int Peek()
    {
        if(Count > 0)
        {
            return _items[0];
        }
        return default(int);
    }

    public void Enqueue(int item)
    {
        _items.Add(item);
        var currentIndex = Count - 1;
        var parentIndex = GetParentIndex(currentIndex);

        while (currentIndex > 0 && _items[parentIndex] < _items[currentIndex])
        {
            Swap(currentIndex, parentIndex);

            currentIndex = parentIndex;
            parentIndex = GetParentIndex(currentIndex);
        }
    }

    private int GetParentIndex(int currentIndex)
    {
        return (currentIndex - 1) / 2;
    }

    private void Swap(int currentIndex, int parentIndex)
    {
        var temp = _items[currentIndex];
        _items[currentIndex] = _items[parentIndex];
        _items[parentIndex] = temp;
    }
}
