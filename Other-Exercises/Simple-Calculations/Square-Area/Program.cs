﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");

            var a = double.Parse(Console.ReadLine());
            var area = a * a;

            Console.WriteLine("Square area = {0}", area);
        }
    }
}
