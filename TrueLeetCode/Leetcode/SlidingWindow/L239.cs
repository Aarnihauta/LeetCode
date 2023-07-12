namespace TrueLeetCode.Leetcode.SlidingWindow;

//https://leetcode.com/problems/sliding-window-maximum/
public class L239
{
    //time limit
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        List<int> result = new List<int>();

        for (int i = k; i <= nums.Length; i++)
        {
            var max = nums[(i - k)..i].Max();
            result.Add(max);
        }

        return result.ToArray();
    }
}
