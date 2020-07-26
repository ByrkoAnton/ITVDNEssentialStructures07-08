using System;
using System.Runtime.CompilerServices;

namespace Structures02Additional
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            int year, month, day;

            Console.Write("Enter day ");
            day = int.Parse(Console.ReadLine());

            Console.Write("Enter month ");
            month = int.Parse(Console.ReadLine());
            
            Console.Write("Enter year ");
            year = int.Parse(Console.ReadLine());

            int birthdayYear = today.Year;
            bool birthdayInNextYear = false;

            if (today.Month > month)
                birthdayInNextYear = true;

            else if(today.Month == month && today.Day>=day) 
                birthdayInNextYear = true;

            if (birthdayInNextYear)
                birthdayYear++;

            DateTime nexBirthday = new DateTime(birthdayYear,month,day);
            
            TimeSpan left = nexBirthday - today;

            Console.WriteLine(left);
        }
    }
}
