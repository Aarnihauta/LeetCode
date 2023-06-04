namespace TrueLeetCode.Leetcode.Strings;

//https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/
public class L2114
{
    public int MostWordsFound(string[] sentences)
    {
        int max = 0;
        foreach(var sentence in sentences)
        {
            max = Math.Max(max, sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length);
        }

        return max;
    }
}
