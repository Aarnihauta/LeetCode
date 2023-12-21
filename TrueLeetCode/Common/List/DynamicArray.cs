namespace TrueLeetCode.DataStructure.List;


public class DynamicMultipicativeArray<T>
{
    private T[] _array;
    private int _size;

    public void Add(T data)
    {
        if (_size == _array.Length)
        {
            Grow(2);
        }
        _array[_size] = data;
        _size++;
    }

    public bool Remove(T item)
    {
        int index = Array.IndexOf(_array, item);

        if (index > 0)
        {
            _array[index] = default;
            return true;
        }

        return false;
    }

    private void Grow(int multiplier)
    {
        var newArr = new T[_size * multiplier];
        Array.Copy(_array, newArr, _size);
        _array = newArr;
    }
}


public class DynamicAdditiveArray<T>
{
    private T[] _array;
    private int _size;

    public void Add(T data)
    {
        if (_size == _array.Length)
        {
            Grow(2);
        }
        _array[_size] = data;
        _size++;
    }

    public bool Remove(T item)
    {
        int index = Array.IndexOf(_array, item);

        if (index > 0)
        {
            _array[index] = default;
            return true;
        }

        return false;
    }

    private void Grow(int multiplier)
    {
        var newArr = new T[_size + 10];
        Array.Copy(_array, newArr, _size);
        _array = newArr;
    }
}