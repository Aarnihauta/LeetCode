namespace TrueLeetCode.Leetcode.Combinatorics;

//https://leetcode.com/problems/find-triangular-sum-of-an-array/
public class L2221
{
    public int TriangularSum(int[] nums)
    {
        List<int> result = new List<int>();
        int count = nums.Length;
        while (count > 1)
        {
            for (int i = 1; i < count; i++)
            {
                int val = nums[i] + nums[i - 1];
                if(val >= 10)
                {
                    val = val % 10;
                }
                result.Add(val);
            }
            nums = result.ToArray();
            result.Clear();
            count--;
        }

        return nums[0];
    }
}
