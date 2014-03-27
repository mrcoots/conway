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
    }
}
