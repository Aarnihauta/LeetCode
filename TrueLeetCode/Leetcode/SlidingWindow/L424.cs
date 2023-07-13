namespace TrueLeetCode.Leetcode.SlidingWindow;

//https://leetcode.com/problems/longest-repeating-character-replacement/
public class L424
{
    public int CharacterReplacement(string s, int k)
    {
        var dict = new Dictionary<char, int>();
        int res = 0;
        int l = 0;

        for (int r = 0; r < s.Length; r++)
        {
            Add(dict, s, r);
            while ((r - l + 1) - dict.Max(x => x.Value) > k)
            {
                dict[s[l]] -= 1;
                l += 1;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }

    private void Add(Dictionary<char, int> dict, string s, int p)
    {
        if (dict.ContainsKey(s[p]))
        {
            dict[s[p]]++;
        }
        else
        {
            dict.Add(s[p], 1);
        }
    }
}
