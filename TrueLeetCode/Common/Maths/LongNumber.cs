using System.Text;

namespace TrueLeetCode.Common.Maths;
public struct LongNumber
{
    private const int _maxDigits = 4;
    private const int _base = 10000;
    private int[] _array;

    public int[] ReadLong(string a)
    {
        _array = new int[CalculateArraySize(a.Length)];

        char ch = a[0];
        int k = 0;
        while (ch != '\n')
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

        return _array = _array[0..(_array.Length - 1)];
    }

    public void Write()
    {
        StringBuilder s = new StringBuilder();
        string ls = (_base / 10).ToString();
        for (int i = _array[0]; i >= 1; i--)
        {
            int l = _array[i].ToString().Length;
            while (l < ls.Length)
            {
                s.Append("0");
                l++;
            }
            s.Append(_array[i]);
        }
        Console.Write(s);
    }

    public LongNumber Sum(LongNumber number)
    {
        var c = new LongNumber();
        int length = Math.Max(this[0], number[0]);
        c._array = new int[length + 2];
        c[0] = length;
        for(int i = 1; i < length + 1; i++)
        {
            c[i + 1] = (c[i] + this[i] + number[i]) / _base;
            c[i] = (c[i] + this[i] + number[i]) % _base;
        }

        if (c[c[0] + 1] > 0)
        {
            c[0]++;
        }
        c._array = c._array[0..(c._array.Length - 1)];
        return c;
    }

    private int CalculateArraySize(int initialSize)
    {
        if (initialSize % _maxDigits == 0)
        {
            return initialSize / _maxDigits + 2;
        }
        else
        {
            return initialSize / _maxDigits + 3;
        }
    }

    public int this[int index]
    {
        get
        {
            return _array[index];
        }
        private set
        {
            _array[index] = value;
        }
    }
}
