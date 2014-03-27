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
            var grid = new bool[5, 5]
            {
                {true, false, true, true, false },
                {false, true, true, false, false },
                {false, false, true, true, true },
                {true, true, false, true, true },
                {true, false, false, false, true }  
            };
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i <5; i++)
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
            for (int k = 0; k < 5; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (grid[k, i] == true)
                    {
                        grid[k, i] = false;
                        Console.Write(" ");
                    }

                    else if (grid[k, i] == false)
                    {
                        grid[k, i] = true;
                        Console.Write("X");
                    }
                }
                Console.WriteLine();

            }

            Console.ReadLine();
            
            

        }



        //private static int CountNeighbors(bool[,] grid, int x, int y)
        //{
        //    int livingNeighborCount = 0;
        //    bool atLeftEdge = (x == 0);
        //    bool atTopEdge = (y == 0);
        //    bool atRightEdge = (x == grid.GetLength(0) - 1);
        //    bool atBottomEdge = (y == grid.GetLength(1) - 1);

        //    if (!atLeftEdge && !atTopEdge && grid[x - 1, y - 1])
        //    {
        //        livingNeighborCount++;
        //    }

        //    if (!atTopEdge && grid[x, y - 1])
        //    {
        //        livingNeighborCount++;
        //    }

        //    if (!atRightEdge && !atTopEdge && grid[x + 1, y - 1])
        //    {
        //        livingNeighborCount++;
        //    }

        //    if (!atLeftEdge && grid[x - 1, y])
        //    {
        //        livingNeighborCount++;
        //    }

        //    if (!atRightEdge && grid[x + 1, y])
        //    {
        //        livingNeighborCount++;
        //    }

        //    if (!atLeftEdge && !atBottomEdge && grid[x - 1, y + 1])
        //    {
        //        livingNeighborCount++;
        //    }

        //    if (!atBottomEdge && grid[x, y + 1])
        //    {
        //        livingNeighborCount++;
        //    }

        //    if (!atRightEdge && !atBottomEdge && grid[x + 1, y + 1])
        //    {
        //        livingNeighborCount++;
        //    }

        //    return livingNeighborCount;
        //}


}
}
