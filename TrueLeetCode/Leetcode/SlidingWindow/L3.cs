namespace TrueLeetCode.Leetcode.SlidingWindow;

//https://leetcode.com/problems/longest-substring-without-repeating-characters
public class L3
{
    public int LengthOfLongestSubstring(string s)
    {
        int max = 0;
        var set = new HashSet<char>();
        for (int i = 0; i < s.Length; i++)
        {
            int j = i;
            while (j < s.Length && set.Add(s[j]))
            {
                j++;
            }
            max = Math.Max(max, set.Count);
            set.Clear();
        }

        return max;
    }
}
