namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/palindromic-substrings/description/
public class L647
{
    public int CountSubstrings(string s)
    {
        var subs = GetSubstrings(s);
        int c = 0;
        foreach (var sub in subs)
        {
            if (IsPalindrome(sub))
            {
                c++;
            }
        }

        return c;
    }

    private bool IsPalindrome(string sub)
    {
        int l = 0;
        int r = sub.Length - 1;

        while (l <= r)
        {
            if (sub[l] != sub[r])
            {
                return false;
            }

            l++;
            r--;
        }

        return true;
    }

    private List<string> GetSubstrings(string s)
    {
        var dp = new List<string>();
        int left = 0;
        int i = 0;

        int count = Zetta(s.Length);
        while (dp.Count != count)
        {
            if (i == (s.Length - left))
            {
                i = 0;
                left++;
            }

            dp.Add(s.Substring(left, ++i));
        }

        return dp;
    }

    private int Zetta(int l)
    {
        return l * (l + 1) / 2;
    }
}
