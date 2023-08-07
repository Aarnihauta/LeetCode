namespace TrueLeetCode.Leetcode.HashTable;

//https://leetcode.com/problems/first-unique-character-in-a-string/
public class L387
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if(dict.ContainsKey(c))
            {
                dict[c].Add(i);
            }
            else
            {
                dict[c] = new List<int> { i };
            }
        }

        for(int i = 0; i < s.Length; i++)
        {
            var val = dict[s[i]];

            if(val.Count == 1)
            {
                return val[0];
            }
        }

        return -1;
    }
}
