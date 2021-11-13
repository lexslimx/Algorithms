using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            HashSet<string> map = new HashSet<string>();
            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.') continue;
                    if (!map.Add(board[i][j] + "found in  row" + i)) return false;
                    if (!map.Add(board[i][j] + "found in  col" + j)) return false;
                    if (!map.Add(board[i][j] + "found in  block" + i / 3 + '-' + j / 3)) return false;
                }
            }
            return true;
        }
    }
}
