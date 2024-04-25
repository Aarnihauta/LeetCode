namespace TrueLeetCode.Common.Maths;
public struct LongNumber
{
    private const int _maxDigits = 3;
    private int[] _array;

    public int[] ReadLong(string a)
    {
        _array = new int[CalculateArraySize(a.Length)];

        for (int i = 0, k = 1; i < a.Length; i++)
        {
            int count = Insert(_array, ref k, Convert.ToInt32(a[i] - '0'));
           
            _array[0] = count;
        }

        return _array;
    }

    private int GetDigitsCount(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        if (n < 0)
        {
            n = -1 * n;
        }

        return (int)Math.Floor(Math.Log10(n) + 1);
    }

    private int GetFirstDigit(int n)
    {
        while (n >= 10)
        {
            n /= 10;
        }

        return n;
    }

    private int Insert(int[] arr, ref int i, int digit)
    {
        int digitsCount = GetDigitsCount(arr[i]);
       
        if (digitsCount < _maxDigits)
        {
            arr[i] = arr[i] * 10 + digit;
        }
        else
        {
            int firstDigit = GetFirstDigit(arr[i]);
            arr[i] = (arr[i] - firstDigit * 100) * 10 + digit;
            i++;
            int count = Insert(arr, ref i, firstDigit);
            i--;
            return count;
        }

        return GetDigitsCount(arr[i]);
    }

    private int CalculateArraySize(int initialSize)
    {
        if (initialSize % 3 == 0)
        {
            return initialSize / 3 + 1;
        }
        else
        {
            return initialSize / 3 + 2;
        }
    }
}
