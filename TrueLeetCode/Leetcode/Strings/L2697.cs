using System.Text;

namespace TrueLeetCode.Leetcode.Strings;

//https://leetcode.com/problems/lexicographically-smallest-palindrome/
public class L2697
{
    public string MakeSmallestPalindrome(string s)
    {
        var sb = new StringBuilder(s);
        int j = s.Length - 1;
        for (int i = 0; i < s.Length; i++)
        {
            char value = s[i];

            char left = s[i];
            char right = s[j];
            if (left != right && i != j)
            {
                value = GetSmallest(left, right);
            }
            j--;

            if(j >= 0)
            {
                if(value == left)
                {
                    sb = sb.Replace(right, value, j + 1, 1);
                }
                else if(value == right)
                {
                    sb = sb.Replace(left, value, i, 1);
                }
            }
        }

        return sb.ToString();
    }

    private char GetSmallest(char c1, char c2)
    {
        return (char)Math.Min(c1, c2);
    }
}
