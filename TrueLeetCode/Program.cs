
using TrueLeetCode.Leetcode.Stack;

MinStack stack = new MinStack();

stack.Push(-10);
stack.Push(14);
stack.Push(-20);
var p = stack.Top();

stack.Pop();
stack.Push(10);
stack.Push(-7);
stack.Push(-7);
stack.Pop();
stack.Pop();

Console.WriteLine();