using TrueLeetCode.Leetcode.DP;

var l = new L64();

int[][] arr = new int[3][]
{
    new int[] { 1, 3, 1 },
    new int[] { 1, 5, 1 },
    new int[] { 4, 2, 1 }
};

int[][] arr2 = new int[2][]
{
    new int[] { 1, 2, 3 },
    new int[] { 4, 5, 6 },
};

int result = l.MinPathSum(arr2);

Console.WriteLine(result);