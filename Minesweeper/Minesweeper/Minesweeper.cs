using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Minesweeper
    {
        static int SizeOfField = 9;
        static int NumberOfMines = 10;

        static int[] LocationOfMines = new int[NumberOfMines];
        static int[,] Topography = new int[SizeOfField, SizeOfField];

    }
}
