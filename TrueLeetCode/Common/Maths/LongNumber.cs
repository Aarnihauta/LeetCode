namespace TrueLeetCode.Common.Maths;
public struct LongNumber
{
    private const int _maxDigits = 3;
    private const int _base = 1000;
    private int[] _array;

    public int[] ReadLong(string a)
    {
        _array = new int[CalculateArraySize(a.Length)];
    
        char ch = a[0];
        int k = 0;
        while(ch != '\n')
        {
            for (int i = _array[0]; i >= 1; i--)
            {
                _array[i + 1] = _array[i + 1] + (_array[i] * 10) / _base;
                _array[i] = (_array[i] * 10) % _base;
            }
            _array[1] = _array[1] + (ch - '0');

            if (_array[_array[0] + 1] > 0)
            {
                _array[0]++;
            }
            k++;
            ch = a[k];
        }

        return _array[0..(_array.Length -1)];
    }

    private int CalculateArraySize(int initialSize)
    {
        if (initialSize % 3 == 0)
        {
            return initialSize / 3 + 2;
        }
        else
        {
            return initialSize / 3 + 3;
        }
    }
}
