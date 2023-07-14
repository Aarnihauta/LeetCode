namespace TrueLeetCode.Leetcode.SlidingWindow;

//https://leetcode.com/problems/minimum-window-substring/
public class L76
{
    public string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(t))
        {
            return string.Empty;
        }

        var countT = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();

        foreach (var c in t)
        {
            AddCharToDictionary(c, countT);
        }

        var have = 0;
        var need = countT.Count;
        var left = 0;
        var res = new[] { -1, -1 };
        var resultLength = int.MaxValue;

        for (var right = 0; right < s.Length; right++)
        {
            var key = s[right];
            AddCharToDictionary(key, window);

            if (countT.ContainsKey(key) && window[key] == countT[key])
            {
                have++;
            }

            while (have == need)
            {
                var windowSize = right - left + 1;
                if (windowSize < resultLength)
                {
                    res = new[] { left, right };
                    resultLength = windowSize;
                }

                window[s[left]]--;
                if (countT.ContainsKey(s[left]) && window[s[left]] < countT[s[left]])
                {
                    have--;
                }

                left++;
            }
        }

        if(resultLength == int.MaxValue)
        {
            return string.Empty;
        }
        else
        {
            return s.Substring(res[0], res[1] - res[0] + 1);
        }
    }

    private void AddCharToDictionary(char c, IDictionary<char, int> dict)
    {
        if (dict.ContainsKey(c)) dict[c]++;
        else dict.Add(c, 1);
    }
}
