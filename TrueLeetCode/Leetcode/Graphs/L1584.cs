namespace TrueLeetCode.Leetcode.Graphs;

//https://leetcode.com/problems/min-cost-to-connect-all-points/
public class L1584
{
    public int MinCostConnectPoints(int[][] points)
    {
        int result = 0;
        int edgesCount = points.Length * (points.Length - 1) / 2;
        var edges = new List<(int[] From, int[] To, int Weight)>();

        for (int i = 0; i < points.Length; i++)
        {
            var v = points[i];

            for (int j = 1; j < points.Length; j++)
            {
                var u = points[j];
                int w = GetWeight(v, u);

                if (!edges.Contains((u, v, w)) && v != u)
                {
                    edges.Add((v, u, w));
                }
            }
        }

        edges = edges.OrderBy(x => x.Weight).ToList();

        Dictionary<int[], HashSet<int[]>> trees = new Dictionary<int[], HashSet<int[]>>();

        foreach (var item in points)
        {
            trees.Add(item, new HashSet<int[]>() { item });
        }

        foreach (var edge in edges)
        {
            var from = trees[edge.From];
            var to = trees[edge.To];

            if (from != to)
            {
                result += edge.Weight;

                foreach (var v in to)
                {
                    from.Add(v);
                    trees[v] = from;
                }
            }
        }

        return result;
    }

    private int GetWeight(int[] p1, int[] p2)
    {
        return Math.Abs(p1[0] - p2[0]) + Math.Abs(p1[1] - p2[1]);
    }
}
