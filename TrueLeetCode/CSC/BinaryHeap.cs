namespace TrueLeetCode.CSC;
public class BinaryHeap
{
    private List<int> _items = new List<int>();

    public BinaryHeap()
    {

    }
    public BinaryHeap(List<int> items)
    {
        _items = items;
        for (int i = Count; i >= 0; i--)
        {
            SiftUp(i);
        }
    }

    public int Count => _items.Count;

    public int Peek()
    {
        if (Count > 0)
        {
            return _items[0];
        }

        return default;
    }

    public int GetMax()
    {
        var result = _items[0];
        _items[0] = _items[^1];
        _items.RemoveAt(Count - 1);

        SiftUp(0);

        return result;
    }

    public void Add(int item)
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

    private void SiftUp(int currentIndex)
    {
        int leftIndex;
        int rightIndex;
        int maxIndex = currentIndex;

        while (currentIndex < Count)
        {
            leftIndex = 2 * currentIndex + 1;
            rightIndex = 2 * currentIndex + 2;

            if (leftIndex < Count && _items[leftIndex] > _items[maxIndex])
            {
                maxIndex = leftIndex;
            }

            if (rightIndex < Count && _items[rightIndex] > _items[maxIndex])
            {
                maxIndex = rightIndex;
            }

            if (maxIndex == currentIndex)
            {
                break;
            }

            Swap(currentIndex, maxIndex);
            currentIndex = maxIndex;
        }
    }
}
