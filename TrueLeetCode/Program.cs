using TrueLeetCode.Leetcode.Trees;


int a = 1;
int b = 0;
int c = 1;
int d = 1;

int curr = 0;

curr = (curr << 1) | a;
curr = (curr << 1) | b;
curr = (curr << 1) | c;

curr = (curr - 1) | d;

Console.WriteLine();