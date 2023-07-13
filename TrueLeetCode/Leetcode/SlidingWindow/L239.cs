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
            var window = nums[(i - k)..i];
            var set = new SortedSet<int>(window);
            result.Add(set.Max);
        }

        return result.ToArray();
    }
}
