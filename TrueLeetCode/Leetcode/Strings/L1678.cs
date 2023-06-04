namespace TrueLeetCode.Leetcode.Strings;

//https://leetcode.com/problems/goal-parser-interpretation/
public class L1678
{
    public string Interpret(string command)
    {
        return command
            .Replace("()", "o")
            .Replace("(al)", "al");
    }
}
