namespace TrueLeetCode.Leetcode.Trees;

//https://leetcode.com/problems/flatten-nested-list-iterator/

public class NestedIterator
{
    private List<int> _items;
    private int _current;
    public NestedIterator(IList<NestedInteger> nestedList)
    {
        _items = new List<int>();
        _current = 0;
        Flat(nestedList);
    }

    public bool HasNext()
    {
        return _current < _items.Count;
    }

    public int Next()
    {
        return _items[_current++];
    }

    private void Flat(IList<NestedInteger> nestedIntegers)
    {
        foreach(var item in nestedIntegers)
        {
            if(item.IsInteger())
            {
                _items.Add(item.GetInteger());
            }
            else
            {
                Flat(item.GetList());
            }
        }
    }
}

public interface NestedInteger {

    bool IsInteger();
    int GetInteger();
    IList<NestedInteger> GetList();
}

public class FlatNestedInt : NestedInteger
{
    public FlatNestedInt(int value)
    {
        Value = value;
    }

    public int Value { get; }

    public int GetInteger()
    {
        return Value;
    }

    public IList<NestedInteger> GetList()
    {
        return Enumerable.Empty<NestedInteger>().ToList();
    }

    public bool IsInteger()
    {
        return true;
    }
}

public class TreeNestedInteger : NestedInteger
{
    private readonly List<NestedInteger> _items;

    public TreeNestedInteger(List<NestedInteger> items)
    {
        _items = items;
    }
    public int GetInteger()
    {
        return 0;
    }

    public IList<NestedInteger> GetList()
    {
        return _items.ToList();
    }

    public bool IsInteger()
    {
        return false;
    }
}