namespace TrueLeetCode.Common.List.RMQ;
public class RangeMinimumQuerMatrix
{
    private readonly int[] _arr;
    private readonly int[,] _lookup;
    public RangeMinimumQuerMatrix(int[] arr)
    {
        _arr = arr;
        _lookup = new int[arr.Length, arr.Length];
        Preprocess();
    }

    public int GetMinimum(int l, int r)
    {
        return _arr[_lookup[l, r]];
    }

    private void Preprocess()
    {
        for (int i = 0; i < _arr.Length; i++)
        {
            _lookup[i, i] = i;
        }

        for (int i = 0; i < _arr.Length; i++)
        {
            for (int j = i + 1; j < _arr.Length; j++)
            {
                if (_arr[_lookup[i, j - 1]] < _arr[j])
                {
                    _lookup[i, j] = _lookup[i, j - 1];
                }
                else
                {
                    _lookup[i, j] = j;
                }
            }
        }
    }
}
