namespace TrueLeetCode.Leetcode.SlidingWindow;

//https://leetcode.com/problems/substrings-of-size-three-with-distinct-characters/
public class L1876
{
    public int CountGoodSubstrings(string s)
    {
        int res = 0;
        int i = 3;
        while (i <= s.Length)
        {
            var dist = s[(i - 3)..i].Distinct().ToList();
            if (dist.Count() == 3)
            {
                res++;
            }
            i++;
        }

        return res;
    }
}
