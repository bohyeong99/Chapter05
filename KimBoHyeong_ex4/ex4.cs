using System;
using static System.Console;
using System.Text;
using System.IO;

namespace baekjoon
{
    class MainApp
    {
        static void Main()
        {
            Write("반복 횟수를 입력하세요. :");
            int input = int.Parse(Console.ReadLine());

            if (input <= 0)
            {
                WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
            }

            for (int i = 0; i < input; i++) 
            {
                for (int j = 0; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}