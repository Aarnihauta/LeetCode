namespace TrueLeetCode.Common.List.SetTheory;
public class UnionFind
{
    private int[] _p;
    private int[] _rank;

    public UnionFind()
    {
        _p = new int[700000];
        _rank = new int[700000];
    }

    public void Make(int x)
    {
        _p[x] = x;
    }

    public int Find(int x)
    {
        if (_p[x] == x)
        {
            return x;
        }

        return _p[x] = Find(_p[x]);
    }

    public void Unite(int x, int y)
    {
        x = Find(x);
        y = Find(y);
        if (_rank[x] == _rank[y])
        {
            _p[x] = y;
        }
        else
        {
            _p[y] = x;
            if (_rank[x] == _rank[y])
            {
                _rank[x]++;
            } 
        }
    }
}
