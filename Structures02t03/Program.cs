using System;
using System.ComponentModel;

namespace Structures02t03
{
    enum Positions
    {
        Worker = 40,
        Driver = 45,
        Cliner = 40,
        Loader = 35,
        Orderer = 45
    }
    class Program
    {
        static void Main(string[] args)
        {
            Positions worker = Positions.Worker;
            Console.WriteLine(Accauntant.AskForBonus(worker, 39));
        }
    }
}
