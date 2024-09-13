using TrueLeetCode.Leetcode.DP;

var l = new L63();

int[][] arr = new int[3][]
{
    new int[] { 0, 0, 0,},
    new int[] { 0, 1, 0,},
    new int[] { 0, 0, 0,}
};

int[][] arr2 = new int[2][]
{
    new int[] { 0, 1,},
    new int[] { 0, 0},
};

int result = l.UniquePathsWithObstacles(arr2);

Console.WriteLine(result);