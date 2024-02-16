namespace TrueLeetCode.Leetcode.Graphs;

//https://leetcode.com/problems/number-of-provinces/
public class L547
{
    private int[] _parent;
    public int FindCircleNum(int[][] isConnected)
    {
        _parent = new int[isConnected.Length];
        for (int i = 0; i < _parent.Length; i++)
        {
            _parent[i] = i;
        }

        for (int i = 0; i < _parent.Length; i++)
        {
            for (int j = 0; j < _parent.Length; j++)
            {
                if (isConnected[i][j] == 1)
                {
                    Union(i, j);
                }
            }
        }
        int c = 0;
        for(int i = 0; i < _parent.Length; i++)
        {
            if(Find(i) == i)
            {
                c++;
            }
        }

        return c;
    }

    private int Find(int x)
    {
        if (_parent[x] == x)
        {
            return x;
        }
        return x = Find(_parent[x]);
    }

    private void Union(int x, int y)
    {
        _parent[Find(x)] = _parent[Find(y)];
    }
}
