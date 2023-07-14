namespace TrueLeetCode.Leetcode.SlidingWindow;

//https://leetcode.com/problems/permutation-in-string/
public class L567
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        int[] s1Arr = new int[26];
        int[] s2Arr = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            s1Arr[s1[i] - 'a']++;
        }

        for (int i = 0; i < s1.Length; i++)
        {
            s2Arr[s2[i] - 'a']++;
        }

        if (s1Arr.SequenceEqual(s2Arr))
        {
            return true;
        }

        for (int i = 1; i < s2.Length - s1.Length + 1; i++)
        {
            s2Arr[s2[i - 1] - 'a']--;
            s2Arr[s2[i + s1.Length - 1] - 'a']++;

            if (s1Arr.SequenceEqual(s2Arr))
            {
                return true;
            }
        }
        return false;
    }
}
