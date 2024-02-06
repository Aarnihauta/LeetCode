namespace TrueLeetCode.Common.Strings;
public class Searching
{
    public static int[] NaiveStringMatch(string t, string p)
    {
        int n = t.Length;
        int m = p.Length;
        List<int> result = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int j;
            for (j = 0; j < m; j++)
            {
                if (t[i + j] != p[j])
                    break;
            }

            if (j == m)
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }
}
