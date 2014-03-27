using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new bool[4, 4]
            {
                {true, false, false, true },
                {false, false, true, false },
                {true, false, true, true },
                {false, true, false, true }
            };
            for (int k = 0; k < 4; k++)
            {
                for (int i = 0; i <4; i++)
                {
                    if (grid[k, i] == true)
                    {
                        Console.Write("X");
                    }
                    else if (grid[k, i] == false)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }

        private static int CountNeighbors(bool[,] grid, int x, int y)
        {
            int livingNeighborCount = 0;
            bool atLeftEdge = (x == 0);
            bool atTopEdge = (y == 0);
            bool atRightEdge = (x == grid.GetLength(0) - 1);
            bool atBottomEdge = (y == grid.GetLength(1) - 1);

            if (!atLeftEdge && !atTopEdge && grid[x - 1, y - 1])
            {
                livingNeighborCount++;
            }

            if (!atTopEdge && grid[x, y - 1])
            {
                livingNeighborCount++;
            }

            if (!atRightEdge && !atTopEdge && grid[x + 1, y - 1])
            {
                livingNeighborCount++;
            }

            if (!atLeftEdge && grid[x - 1, y])
            {
                livingNeighborCount++;
            }

            if (!atRightEdge && grid[x + 1, y])
            {
                livingNeighborCount++;
            }

            if (!atLeftEdge && !atBottomEdge && grid[x - 1, y + 1])
            {
                livingNeighborCount++;
            }

            if (!atBottomEdge && grid[x, y + 1])
            {
                livingNeighborCount++;
            }

            if (!atRightEdge && !atBottomEdge && grid[x + 1, y + 1])
            {
                livingNeighborCount++;
            }

            return livingNeighborCount;
        }
    }
}
