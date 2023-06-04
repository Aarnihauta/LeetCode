namespace TrueLeetCode.Leetcode.Strings;

//https://leetcode.com/problems/reverse-prefix-of-word/
public class L2000
{
    public string ReversePrefix(string word, char ch)
    {
        int index = word.IndexOf(ch);

        if(index < 0)
        {
            return word;
        }

        string substr = word.Substring(0, index + 1);
        return new string(substr.Reverse().ToArray()) + word[(index + 1)..];
    }
}
