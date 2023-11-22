using TrueLeetCode.Leetcode.Arrays;

var l = new L2373();

var matrix = new int[][]
{
    new int[] { 1,1,1,1,1 },
    new int[] { 1,1,1,1,1 },
    new int[] { 1,1,2,1,1 },
    new int[] { 1,1,1,1,1 },
    new int[] { 1,1,1,1,1 },
};

var q =  l.LargestLocal(matrix);
Console.WriteLine(q);