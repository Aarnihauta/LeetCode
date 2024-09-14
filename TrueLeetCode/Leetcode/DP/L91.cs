namespace TrueLeetCode.Leetcode.DP;

//https://leetcode.com/problems/decode-ways
public class L91
{
    public int NumDecodings(string s)
    {
        if (string.IsNullOrEmpty(s) || s[0] == '0') return 0;

        int n = s.Length;
        int[] memo = new int[n + 1];
        Array.Fill(memo, -1);

        return Decode(s, n, memo);
    }

    private int Decode(string s, int k, int[] arr)
    {
        if (k == 0)
        {
            return 1;
        }

        int start = s.Length - k;
        if (s[start] == '0')
        {
            return 0;
        }
        if (arr[k] != -1)
            return arr[k];

        int path = Decode(s, k - 1, arr);

        if (k >= 2 && int.Parse(s.Substring(start, 2)) <= 26)
        {
            path += Decode(s, k - 2, arr);
        }

        arr[k] = path;
        return path;
    }
}
