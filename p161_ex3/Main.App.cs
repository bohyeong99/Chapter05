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
            Console.Write("몇월이 궁금하세요? : ");
            int month = int.Parse(Console.ReadLine());

            if (month < 1 || month > 12)
            {
                Console.WriteLine("Invalid month.");
            }
            else
            {
                Console.Write("연도를 입력하시오. : ");
                int year = int.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(year, month);
                Console.WriteLine($"There are {daysInMonth} days in the month of {month}/{year}.");
            }
        }
    }
}
    

