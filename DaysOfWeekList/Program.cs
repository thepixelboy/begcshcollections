using System;
using System.Collections.Generic;

namespace DaysOfWeekList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> daysOfWeek = new List<string>();
            daysOfWeek.Add("Monday");
            daysOfWeek.Add("Tuesday");
            daysOfWeek.Add("Wednesday");
            daysOfWeek.Add("Thursday");
            daysOfWeek.Add("Friday");
            daysOfWeek.Add("Saturday");
            daysOfWeek.Add("Sunday");

            Console.WriteLine("Which day do you want to display?");
            Console.Write("(Monday = 1, etc.) > ");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[iDay - 1]; // Arrays are 0 index based
            Console.WriteLine($"That days is {chosenDay}");
        }
    }
}
