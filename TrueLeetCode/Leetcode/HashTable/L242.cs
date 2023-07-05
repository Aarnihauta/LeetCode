namespace TrueLeetCode.Leetcode.HashTable;

//https://leetcode.com/problems/valid-anagram
public class L242
{
    public bool IsAnagram(string s, string t)
    {
        return s.OrderBy(x => x).SequenceEqual(t.OrderBy(x => x));
    }
}
