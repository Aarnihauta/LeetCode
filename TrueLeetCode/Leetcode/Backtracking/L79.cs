namespace TrueLeetCode.Leetcode.Backtracking;

//https://leetcode.com/problems/word-search
public class L79
{
    public bool Exist(char[][] board, string word)
    {
        bool result = false;
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == word[0])
                {
                    result = result || Backtrack(board, i, j, word, 0, new char[word.Length]);
                }
            }
        }

        return result;
    }

    private bool Backtrack(char[][] board, int i, int j, string word, int offset, char[] current)
    {
        if (i >= board.Length || j >= board[0].Length || i < 0 || j < 0 || offset >= word.Length || board[i][j] == char.MinValue)
        {
            return false;
        }

        var val = board[i][j];
        board[i][j] = char.MinValue;
        if (val == word[offset])
        {
            current[offset] = val;
            Backtrack(board, i - 1, j, word, offset + 1, current);
            Backtrack(board, i + 1, j, word, offset + 1, current);
            Backtrack(board, i, j - 1, word, offset + 1, current);
            Backtrack(board, i, j + 1, word, offset + 1, current);
        }
        board[i][j] = val;

        return word.SequenceEqual(current);
    }
}
