using TrueLeetCode.Leetcode.HashTable;

var l = new L36();

char[][] table = new char[][]
{

     new char[]{'5','3','.','.','7','.','.','.','.'}
    ,new char[]{'6','.','.','1','9','5','.','.','.'}
    ,new char[]{'.','9','8','.','.','.','.','6','.'}
    ,new char[]{'8','.','.','.','6','.','.','.','3'}
    ,new char[]{'4','.','.','8','.','3','.','.','1'}
    ,new char[]{'7','.','.','.','2','.','.','.','6'}
    ,new char[]{'.','6','.','.','.','.','2','8','.'}
    ,new char[]{'.','.','.','4','1','9','.','.','5'}
    ,new char[]{'.','.','.','.','8','.','.','7','9'}
};

for (int i = 3; i < 6; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(table[i][j]);
    }
    Console.WriteLine();
}

//for (int i = 0; i < 9; i++)
//{
//    for (int j = 0; j < 9; j++)
//    {
//        Console.Write(table[i][j] + " ");
//    }
//    Console.WriteLine();
//}

l.IsValidSudoku(table);