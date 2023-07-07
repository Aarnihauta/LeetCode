namespace TrueLeetCode.Leetcode.HashTable;

//https://leetcode.com/problems/valid-sudoku/
public class L36
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] squares = new HashSet<char>[9];
        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            squares[i] = new HashSet<char>();
        }

        for (int r = 0; r < board.Length; r++)
        {
            for (int c = 0; c < board[r].Length; c++)
            {
                char current = board[r][c];
                int boxIndex = (3 * (r / 3)) + (c / 3);

                if (current == '.')
                {
                    continue;
                }

                if (!rows[r].Add(current) ||
                    !cols[c].Add(current) ||
                    !squares[boxIndex].Add(current))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
