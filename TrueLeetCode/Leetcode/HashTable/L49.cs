namespace TrueLeetCode.Leetcode.HashTable;

//https://leetcode.com/problems/group-anagrams/
public class L49
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> result = new Dictionary<string, IList<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            string key = new string(strs[i].OrderBy(x => x).ToArray());

            if (result.TryGetValue(key, out var value))
            {
                value.Add(strs[i]);
            }
            else
            {
                result.Add(key, new List<string>
                {
                    strs[i]
                });
            }
        }

        return result.Values.ToList();
    }
}
