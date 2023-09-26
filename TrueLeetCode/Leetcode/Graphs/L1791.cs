namespace TrueLeetCode.Leetcode.Graphs;

//https://leetcode.com/problems/find-center-of-star-graph/
public class L1791
{
    public int FindCenter(int[][] edges)
    {
        var e1 = edges[0];
        var e2 = edges[1];

        var intersect = e1.Intersect(e2).First();
        return intersect;
    }
}
