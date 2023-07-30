namespace TrueLeetCode.Leetcode.Arrays;

//https://leetcode.com/problems/find-target-indices-after-sorting-array/
public class L2089
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        Array.Sort(nums);

        List<int> result = new List<int>();

        int start = Array.IndexOf(nums, target);

        if (start == -1)
        {
            return result;
        }

        while (start < nums.Length)
        {
            if (nums[start] == target)
            {
                result.Add(start);
                start++;
            }
            else
            {
                break;
            }
        }

        return result;

    }
}
