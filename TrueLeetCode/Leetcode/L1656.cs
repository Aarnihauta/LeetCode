namespace TrueLeetCode.Leetcode;

//https://leetcode.com/problems/design-an-ordered-stream
public class OrderedStream
{
    private int _pointer;
    private string[] _array;
    public OrderedStream(int n)
    {
        _array = new string[n];
    }

    public IList<string> Insert(int idKey, string value)
    {
        var result = new List<string>();
        _array[idKey] = value;

        while (_pointer < _array.Length && _array[_pointer] != null)
        {
            result.Add(_array[_pointer]);
            _pointer++;
        }
        return result;
    }
}