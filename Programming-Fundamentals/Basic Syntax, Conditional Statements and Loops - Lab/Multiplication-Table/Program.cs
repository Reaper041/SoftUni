﻿using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            for (int times = 1; times <= 10; times++)
            {
                Console.WriteLine($"{integer} X {times} = {integer * times}");
            }
        }
    }
}
