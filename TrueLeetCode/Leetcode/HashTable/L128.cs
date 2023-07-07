namespace TrueLeetCode.Leetcode.HashTable;

//https://leetcode.com/problems/longest-consecutive-sequence/
public class L128
{
    public int LongestConsecutive(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        int longestChain = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                nums[i]++;
            }
            else
            {
                dict.Add(nums[i], 1);
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            var key = nums[i] - 1;

            if (!dict.ContainsKey(key))
            {
                var next = nums[i];
                int current = 0;
                while (dict.ContainsKey(next))
                {
                    current += dict[next];
                    longestChain = Math.Max(longestChain, current);
                    next++;
                }
            }
        }

        return longestChain;
    }
}
