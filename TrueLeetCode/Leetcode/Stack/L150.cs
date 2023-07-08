namespace TrueLeetCode.Leetcode.Stack;

//https://leetcode.com/problems/evaluate-reverse-polish-notation/
public class L150
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        for (int i = 0; i < tokens.Length; i++)
        {
            var c = tokens[i];

            if (c == "*" || c == "/" || c == "+" || c == "-")
            {
                var right = Convert.ToInt32(stack.Pop());
                var left = Convert.ToInt32(stack.Pop());

                var val = Evaluate(left, right, c);
                stack.Push(val);
            }
            else
            {
                stack.Push(Convert.ToInt32(c));
            }
        }
        return stack.Peek();
    }

    private int Evaluate(int left, int right, string op)
    {
        return op switch
        {
            "*" => left * right,
            "/" => left / right,
            "-" => left - right,
            "+" => left + right,
        };
    }
}