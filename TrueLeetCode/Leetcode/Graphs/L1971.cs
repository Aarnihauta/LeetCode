namespace TrueLeetCode.Leetcode.Graphs;

//https://leetcode.com/problems/find-if-path-exists-in-graph/
public class L1971
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        var list = new List<int>[n];
        bool[] visited = new bool[n];

        for (int i = 0; i < n; i++)
        {
            list[i] = new List<int>();
        }

        foreach (var edge in edges)
        {
            int from = edge[0];
            int to = edge[1];
            list[from].Add(to);
            list[to].Add(from);
        }

        return ContainsPath(source, destination, list, visited);
    }

    private bool ContainsPath(int source, int dest, List<int>[] list, bool[] visited)
    {
        if (source == dest)
        {
            return true;
        }

        if (!visited[source])
        {
            visited[source] = true;
            foreach(var paths in list[source])
            {
                if(ContainsPath(paths, dest, list, visited))
                {
                    return true;
                }
            }
        }

        return false;
    }
}
