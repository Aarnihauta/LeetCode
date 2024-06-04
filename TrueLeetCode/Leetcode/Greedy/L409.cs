namespace TrueLeetCode.Leetcode.Greedy;

//https://leetcode.com/problems/longest-palindrome/
public class L409
{
    public int LongestPalindrome(string s)
    {
        var ascii = new char[128];
        for (int i = 0; i < s.Length; i++)
        {
            ascii[s[i]]++;
        }
        int result = 0;
        bool odd = false;

        foreach (int c in ascii)
        {
            if (c % 2 == 0)
            {
                result += c;
            }
            else
            {
                result += c - 1;
                odd = true;
            }
        }


        if (odd)
        {
            result++;
        }

        return result;
    }
}
