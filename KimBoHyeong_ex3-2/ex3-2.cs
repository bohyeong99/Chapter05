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
            int i = 5;

            do
            {
                int j = 0;
                while (j < i)
                {
                    Write("*");
                    j++;
                }
                WriteLine();
                i--;
            }
            while (i > 0);
        }
    }
}