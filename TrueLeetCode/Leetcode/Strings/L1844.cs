using System.Text;

namespace TrueLeetCode.Leetcode.Strings;

//https://leetcode.com/problems/replace-all-digits-with-characters/
public class L1844
{
    public string ReplaceDigits(string s)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (i % 2 == 0)
            {
                sb.Append(s[i]);
            }
            else
            {
                int shift = s[i] - '0';
                sb.Append(Shift(s[i - 1], shift));
            }
        }

        return sb.ToString();
    }

    private char Shift(char c, int shift)
    {
        return (char)(c + shift);
    }
}
