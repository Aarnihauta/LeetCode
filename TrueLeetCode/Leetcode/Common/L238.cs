namespace TrueLeetCode.Leetcode.Common;

//https://leetcode.com/problems/product-of-array-except-self/
public class L238
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];

        int prefix = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }

        int postfix = 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= postfix;
            postfix *= nums[i];
        }

        return result;
    }
}
