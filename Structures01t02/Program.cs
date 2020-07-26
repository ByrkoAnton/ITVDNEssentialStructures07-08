using System;

namespace Structures01t02
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainStruct[] trains = new TrainStruct[]
            {
                new TrainStruct(2,"Kiev",new DateTime(2020,7,10,11,45,00)),
                new TrainStruct(6,"Lviv",new DateTime(2020,7,11,11,40,00)),
                new TrainStruct(1,"Kharkov",new DateTime(2020,8,17,16,50,00)),
                new TrainStruct(88,"Odessa",new DateTime(2020,6,15,14,44,00)),
                new TrainStruct(232,"Kiev",new DateTime(2020,8,20,20,20,00)),
                new TrainStruct(22,"Debaltsevo",new DateTime(2020,9,10,11,45,00)),
                new TrainStruct(21,"Chernigov",new DateTime(2020,9,11,11,45,00)),
                new TrainStruct(6543,"Konotop",new DateTime(2020,10,12,10,45,00)),
            };

            foreach (var VARIABLE in trains)
            {
                VARIABLE.ShowInfo();
                Console.WriteLine();
            }
            
            Array.Sort(trains);

            Console.WriteLine("-----------------------------");
            foreach (var VARIABLE in trains)
            {
                VARIABLE.ShowInfo();
                Console.WriteLine();
            }

            Console.Write("enter train number ");

            trains.ShowTrainByNumber(int.Parse(Console.ReadLine() ?? string.Empty));
        }
    }
}
