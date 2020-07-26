using System;
using System.Collections.Generic;
using System.Text;

namespace Structures01t02
{
    public static class TrainExtention
    {
        public static void ShowTrainByNumber(this TrainStruct[] train,  int trainNum )
        {
            foreach (var variable in train)
            {
                if (trainNum == variable._trainNumber)
                {
                    variable.ShowInfo();
                    return;
                }
            }

            Console.WriteLine("no train with this number");
        }
    }
}
