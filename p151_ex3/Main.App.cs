using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요.");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);


            if (number >= 50)
                Console.WriteLine($"{number}는 50이상의 정수입니다.");


            else
            {
                Console.WriteLine($"{number}는 50미만의 정수입니다.");
            }
        }
    }
}
