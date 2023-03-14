using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("세개의 정수 중 첫번째 정수를 입력하시오. : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third integer: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max = num1;
            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }

            int min = num1;
            if (num2 < min)
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }

            int sum = num1 + num2 + num3;
            double avg = (double)sum / 3;

            Console.WriteLine("Maximum: " + max + ", Minimum: " + min + ", Sum: " + sum + ", Average: " + avg);
        }
    }
}
//사용자로부터 세개의 정수를 입력받아, 그 수들의 최대값과 최소값,
//합계와 평균을 구하는 프로그램을 만들어주세요.
    





