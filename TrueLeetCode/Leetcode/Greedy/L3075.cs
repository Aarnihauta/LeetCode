namespace TrueLeetCode.Leetcode.Greedy;

//https://leetcode.com/problems/maximize-happiness-of-selected-children/k
public class L3075
{
    public long MaximumHappinessSum(int[] happiness, int k)
    {
        Array.Sort(happiness);
        int m = 0;
        long res = 0;
        for (int i = happiness.Length - 1; k > 0; i--, k--)
        {
            if (happiness[i] - m > 0)
            {
                res += happiness[i] - m;
            }
            m++;
        }

        return res;
    }
}
