﻿using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());

            double price = area * 7.61;
            double discount = price * 0.18;
            double finalPrice = price - discount;

            Console.WriteLine("The final price is: {0:f2} lv.", finalPrice);
            Console.WriteLine("The discount is: {0:f2} lv.", discount);
        }
    }
}
