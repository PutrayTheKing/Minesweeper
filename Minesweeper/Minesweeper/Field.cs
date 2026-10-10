using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Field
    {
        public bool IsBomb = false;
        public int BombsNearby = 0;
        public bool IsRevealed = false;
        public bool IsFlagged = false;

    }
}
