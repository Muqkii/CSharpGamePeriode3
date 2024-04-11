using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periode3Csharpgame
{
    internal class Grid
    {
        static int gridX = 20;
        static int gridY = 20;

        static int markerX;
        static int markerY;

        static int playerX;
        static int playerY;

        public static void gridOne()
        {
            for (int i = 0; i < gridX; i++)
            {
                for(int j = 0; j < gridY; j++)
                {
                    if(j + 1 == markerX && i + 1 == markerY)
                    {
                        Console.WriteLine("o ", Console.ForegroundColor = ConsoleColor.Green);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else if(j + 1 == playerX && i + 1 == markerY)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("o ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Move(string[] menu)
        {
            switch (menu)
            {
                case "Up":

            }
        }
    }
}
