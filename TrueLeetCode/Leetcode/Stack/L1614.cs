namespace TrueLeetCode.Leetcode.Stack;

//https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses
public class L1614
{
    public int MaxDepth(string s)
    {
        int currentMax = 0;
        int result = 0;
        foreach (var c in s)
        {
            if (c == '(')
            {
                currentMax++;
            }
            else if (c == ')')
            {
                result = Math.Max(result, currentMax--);
            }
        }

        return result;
    }
}
