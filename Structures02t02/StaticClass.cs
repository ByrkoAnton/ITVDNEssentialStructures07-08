using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace Structures02t02
{
    static class StaticClass
    {
        public enum Color
        {
            White=1,
            Black,
            Green,
            Blue
        }

        public static void ShowColors()
        {
            int tmp = 1;
            foreach (var i in Enum.GetValues(typeof(Color)))
            {
                Console.WriteLine($"{(int)i} - {i}");
            }
            
        }
        public static void Print(string str, int color)
        {
            Color col = (Color) color;
            switch (col)
            {
                case Color.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(str);
                    break;
                case Color.Black:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(str);
                    break;
                case Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(str);
                    break;
                case Color.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(str);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            Console.ResetColor();
        }
    }
}
