﻿using System;
using static System.Console;
using System.Text;
using System.IO;

namespace KimBoHyeong_ex1 
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) 
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