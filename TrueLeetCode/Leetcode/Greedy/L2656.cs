namespace TrueLeetCode.Leetcode.Greedy;

//https://leetcode.com/problems/maximum-sum-with-exactly-k-elements/
public class L2656
{
    public int MaximizeSum(int[] nums, int k)
    {
        int max = nums.Max();
        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += max;
            max++;
        }

        return sum;
    }
}
