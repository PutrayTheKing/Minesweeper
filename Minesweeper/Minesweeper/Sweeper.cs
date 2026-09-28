using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Sweeper
    {
        static int SizeOfField = 9;
        static int NumberOfMines = 10;

        static int[] LocationOfMines = new int[NumberOfMines];
        static int[,] Topography = new int[SizeOfField, SizeOfField];

        public static void CreateMines()
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

        static void CreateTopography()
        {
            for (int i = 0; i < NumberOfMines; i++)
            {
                int posX = LocationOfMines[i] % SizeOfField;
                int posY = LocationOfMines[i] / SizeOfField;


                if (posX > 0 && posY > 0)
                    Topography[posX - 1, posY - 1]++;

                if (posX > 0)
                    Topography[posX - 1, posY]++;

                if (posX > 0 && posY < SizeOfField)
                    Topography[posX - 1, posY + 1]++;



                if (posY > 0)
                    Topography[posX, posY - 1]++;

                if (posY < SizeOfField)
                    Topography[posX, posY + 1]++;



                if (posX < SizeOfField && posY > 0)
                    Topography[posX + 1, posY - 1]++;

                if (posX < SizeOfField)
                    Topography[posX + 1, posY]++;

                if (posX < SizeOfField && posY < SizeOfField)
                    Topography[posX + 1, posY + 1]++;   
            }

            for (int i = 0; i < NumberOfMines; i++)
            {
                int posX = LocationOfMines[i] % SizeOfField;
                int posY = LocationOfMines[i] / SizeOfField;

                Topography[posX, posY] = -1;
            }
        }
    }
}
