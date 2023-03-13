using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요.");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number > 0)
            {
                if (number >= 90)
                    //Console.WriteLine("A");
                    Console.WriteLine($"입력하신 점수" + $"는 {number}는(은) A 학점 입니다.");

                if (number >= 80)
                    //Console.WriteLine("B");
                    Console.WriteLine($"입력하신 점수" + $"는 {number}는(은) B 학점 입니다.");

                if (number >= 70)
                    //Console.WriteLine("C");
                    Console.WriteLine($"입력하신 점수" + $"는 {number}는(은) C 학점 입니다.");

                else
                {
                    //Console.WriteLine("F");
                    Console.WriteLine($"입력하신 점수" + $"는 {number}는(은) F 학점 입니다.");

                }
            }
        }
    }
}
