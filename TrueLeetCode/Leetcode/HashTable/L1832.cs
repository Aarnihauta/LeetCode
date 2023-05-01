namespace TrueLeetCode.Leetcode.HashTable;

//https://leetcode.com/problems/check-if-the-sentence-is-pangram
public class L1832
{
    public bool CheckIfPangram(string sentence)
    {
        var alphabet = Enumerable.Range('a', 26).ToDictionary(x => (char)x, x => 0);

        foreach(var c in sentence)
        {
            if(char.IsLetter(c))
            {
                alphabet[c]++;
            }
        }

        return alphabet.All(x => x.Value > 0);
    }
}
