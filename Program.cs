﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10090974_OOP_Concepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 7;
            double y = 7;

            Shape sha = new Shape(x,y);
            Console.WriteLine("Area: " + sha.calculate());
            Console.ReadLine();
            
        }
    }
}