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

        static void CreateMines()
        {
            Random rnd = new Random();

            int counter = 0;

            while (counter < NumberOfMines)
            {
                int random = rnd.Next(0, (SizeOfField * SizeOfField));

                if (!LocationOfMines.Contains(random))
                {
                    LocationOfMines[counter] = random;
                    counter++;
                }
            }
        }


    }
}
