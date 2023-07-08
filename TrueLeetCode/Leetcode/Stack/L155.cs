namespace TrueLeetCode.Leetcode.Stack;

//https://leetcode.com/problems/min-stack
public class MinStack
{
    private int[] _stack;
    private int[] _minStack;
    private int _pointer;

    public MinStack()
    {
        _stack = new int[4];
        _minStack = new int[4];
        _pointer = 0;
    }

    public void Push(int val)
    {
        if (_pointer == _stack.Length)
        {
            Resize();
        }

        _stack[_pointer] = val;

        if (_pointer == 0)
        {
            _minStack[_pointer] = val;
        }
        else
        {
            _minStack[_pointer] = Math.Min(_minStack[_pointer - 1], val);
        }

        _pointer++;
    }

    public void Pop()
    {
        if (_pointer > 0)
        {
            _stack[_pointer - 1] = default;
            _minStack[_pointer - 1] = default;
            _pointer--;
        }
    }

    public int Top()
    {
        if (_pointer > 0)
        {
            return _stack[_pointer - 1];
        }
        return default;
    }

    public int GetMin()
    {
        if (_pointer > 0)
        {
            return _minStack[_pointer - 1];
        }
        return default;
    }

    private void Resize()
    {
        int size = _stack.Length * 2;
        var stack = new int[size];
        var minStack = new int[size];

        Array.Copy(_stack, stack, _stack.Length);
        Array.Copy(_minStack, minStack, _minStack.Length);

        _stack = stack;
        _minStack = minStack;
    }
}