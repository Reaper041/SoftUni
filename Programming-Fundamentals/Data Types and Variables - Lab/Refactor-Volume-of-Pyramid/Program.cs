﻿using System;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double volumeStem = width * length;
            double volume = volumeStem * height / 3;
            Console.Write($"Pyramid Volume: {volume:f2}");

        }
    }
}
