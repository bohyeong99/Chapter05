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
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 5; j > i; j--) 
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}