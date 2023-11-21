namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/create-target-array-in-the-given-order/
public class L1389
{
    public int[] CreateTargetArray(int[] nums, int[] index)
    {
        List<int> result = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            result.Insert(index[i], nums[i]);
        }
        return result.ToArray();
    }
}
