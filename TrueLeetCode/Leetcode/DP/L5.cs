namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/longest-palindromic-substring
public class L5
{
    public string LongestPalindrome(string s)
    {
        if (s.Length == 1)
        {
            return s;
        }

        string max = "";
        int l = 0;
        int r = s.Length - 1;

        while (l <= r && r > 0)
        {
            if (s[l] != s[r])
            {
                r--;
            }

            var ltemp = l;
            var rtemp = r;
            bool p;
            while (p = !IsPalindrome(s[ltemp..(rtemp+1)]) && rtemp > 0)
            {
                rtemp--;
            }

            if(!p && s[ltemp..(rtemp+1)].Length >= max.Length) 
            {
                max = s[ltemp..(rtemp + 1)];
            }

            l++;
            r = s.Length - 1;
        }

        return max;
    }

    private bool IsPalindrome(string s)
    {
        for (int l = 0, r = s.Length - 1; l < r; l++, r--)
        {
            if (s[l] != s[r])
            {
                return false;
            }
        }

        return true;
    }
}
