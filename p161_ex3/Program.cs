using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month.");
            }
            else
            {
                Console.Write("Enter a year: ");
                int year = int.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(year, month);
                Console.WriteLine($"There are {daysInMonth} days in the month of {month}/{year}.");
            }
        }
    }
}
    

