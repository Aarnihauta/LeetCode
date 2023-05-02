namespace TrueLeetCode.Leetcode.Stack;

//https://leetcode.com/problems/valid-parentheses/
public class L20
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (var c in s)
        {
            if(c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                if(stack.Count == 0)
                {
                    return false;
                }

                if ((c == ')' && stack.Peek() == '(') ||
                    (c == ']' && stack.Peek() == '[') ||
                    (c == '}' && stack.Peek() == '{'))
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
