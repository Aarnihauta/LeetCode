namespace TrueLeetCode.Leetcode.Stack;

//https://leetcode.com/problems/generate-parentheses/
public class L22
{
    public IList<string> GenerateParenthesis(int n)
    {
        Stack<string> _stack = new Stack<string>();
        List<string> _result = new List<string>();
        Backtrack(0, 0);

        return _result;

        void Backtrack(int openN, int closedN)
        {
            if (openN == closedN && closedN == n)
            {
                _result.Add(string.Join("", _stack.Reverse()));
                return;
            }

            if (openN < n)
            {
                _stack.Push("(");
                Backtrack(openN + 1, closedN);
                _stack.Pop();
            }

            if (closedN < openN)
            {
                _stack.Push(")");
                Backtrack(openN, closedN + 1);
                _stack.Pop();
            }
        }
    }
}
