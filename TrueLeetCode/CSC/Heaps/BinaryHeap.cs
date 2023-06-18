namespace TrueLeetCode.CSC.Heap;
public class BinaryHeap
{
    private List<int> _items;
    public int Count => _items.Count;

    public int GetMax()
    {
        if(Count > 0)
        {
            return _items[0];
        }
        return default(int);
    }

    public void Add(int item)
    {
        _items.Add(item);
        var currentIndex = Count - 1;
        var parentIndex = (currentIndex - 1) / 2;

        while(currentIndex > 0 && _items[parentIndex] < _items[currentIndex])
        {
            var temp = _items[currentIndex];
            _items[currentIndex] = _items[parentIndex];
            _items[parentIndex] = temp;
        }
    }
}
