namespace TrueLeetCode.Leetcode.Graphs;

//https://leetcode.com/problems/find-the-town-judge/
public class L997
{
    public int FindJudge(int n, int[][] trust)
    {
        int[] arr1 = new int[n + 1];
        int[] arr2 = new int[n + 1];

        for (int i = 0; i < trust.Length; i++)
        {
            int v = trust[i][0];
            int u = trust[i][1];
            arr1[v]++;
            arr2[u]++;
        }

        for(int i = 1; i < arr1.Length; i++)
        {
            if (arr1[i] == 0 && arr2[i] == n - 1)
            {
                return i;
            }
        }

        return -1;
    }
}
