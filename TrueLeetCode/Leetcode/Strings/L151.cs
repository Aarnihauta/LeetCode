namespace TrueLeetCode.Leetcode.Strings;
public class L151
{
    public string ReverseWords(string s)
    {
        var arr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(arr);

        return string.Join(' ', arr);
    }
}
