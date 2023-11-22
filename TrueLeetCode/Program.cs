using TrueLeetCode.Leetcode.Arrays;

var l = new L1672();

var matrix = new int[][]
{
    new int[] { 2, 8, 7 },
    new int[] { 7, 1, 3 },
    new int[] { 1, 9, 5 },
};

var q =  l.MaximumWealth(matrix);
Console.WriteLine(q);