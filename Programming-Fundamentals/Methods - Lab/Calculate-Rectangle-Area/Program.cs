﻿using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = GetAreaOfRectagle(a, b);
            Console.WriteLine(area);
        }

        static double GetAreaOfRectagle(double a, double b)
        {
            return a * b;
        }
    }
}
