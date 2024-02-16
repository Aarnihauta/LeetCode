using TrueLeetCode.Leetcode.Arrays;

var l = new L695();

var arr = new int[][]
{
    new int[] { 0,0,1,0,0,0,0,1,0,0,0,0,0},
    new int[] { 0,0,0,0,0,0,0,1,1,1,0,0,0},
    new int[] { 0,1,1,0,1,0,0,0,0,0,0,0,0},
    new int[] { 0,1,0,0,1,1,0,0,1,0,1,0,0},
    new int[] { 0,1,0,0,1,1,0,0,1,1,1,0,0},
    new int[] { 0,0,0,0,0,0,0,0,0,0,1,0,0},
    new int[] { 0,0,0,0,0,0,0,1,1,1,0,0,0},
    new int[] { 0,0,0,0,0,0,0,1,1,0,0,0,0}
};


var q = l.MaxAreaOfIsland(arr);
Console.WriteLine(q);