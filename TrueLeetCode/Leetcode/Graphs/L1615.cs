
namespace TrueLeetCode.Leetcode.Graphs;

//https://leetcode.com/problems/maximal-network-rank
public class L1615
{
    public int MaximalNetworkRank(int n, int[][] roads)
    {
        int[] arr = new int[n];
        bool[,] visited = new bool[n, n];
        var max = 0;

        for (int i = 0; i < roads.Length; i++)
        {
            var from = roads[i][0];
            var to = roads[i][1];

            arr[from]++;
            arr[to]++;
            visited[from, to] = true;
            visited[to, from] = true;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                var rank = arr[i] + arr[j];
                if (visited[i, j])
                {
                    rank--;
                }
                max = Math.Max(max, rank);
            }
        }

        return max;
    }
}
