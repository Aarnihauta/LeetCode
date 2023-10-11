namespace TrueLeetCode.Leetcode.Graphs;

//https://leetcode.com/problems/all-paths-from-source-to-target/
public class L797
{
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        IList<IList<int>> res = new List<IList<int>>();
        DFS(graph, new List<int> { 0 }, res);
        return res;

    }
    private void DFS(int[][] graph, List<int> path, IList<IList<int>> result)
    {
        int current = path[path.Count - 1];
        if (path[path.Count - 1] == graph.Length - 1)
        {
            result.Add(path);
            return;
        }
        for (int i = 0; i < graph[current].Length; i++)
        {
            List<int> copiedPath = new List<int>(path)
            {
                graph[current][i]
            };
            DFS(graph, copiedPath, result);
        }
    }
}
