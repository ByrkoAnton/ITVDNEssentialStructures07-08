using System;

namespace Structures02t02
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.ShowColors();

            Console.Write("Enter color number ");
            int col = int.Parse(Console.ReadLine());

            Console.Write("Enter text ");

            string text = Console.ReadLine();

            StaticClass.Print(text,col);
        }
    }
}
