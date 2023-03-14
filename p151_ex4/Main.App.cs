using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하시오 : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 3 == 0)
            {
                Console.WriteLine(number + " 는 3의 배수입니다.");
            }
            else
            {
                Console.WriteLine(number + " 는 3의 배수가아닙니다.");
            }
        }
    }

    //정수 한개를 입력받아서, 그 수가 3의 배수인지 판단하는 프로그램을 만드시오

}
    

