namespace TrueLeetCode.Leetcode.Pointers;

//https://leetcode.com/problems/valid-palindrome/
public class L125
{
    public bool IsPalindrome(string s)
    {
        var data = s
            .Where(char.IsLetterOrDigit)
            .ToArray();

        for (int i = 0, j = data.Length - 1; i < data.Length / 2; i++, j--)
        {
            if (char.ToUpper(data[i]) != char.ToUpper(data[j]))
            {
                return false;
            }
        }
        return true;
    }
}
