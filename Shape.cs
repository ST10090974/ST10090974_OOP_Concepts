using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10090974_OOP_Concepts
{
    internal class Shape
    {
        double length;
        double width;

        public Shape()
        {
        }

        public Shape(double l, double w)
        {
            length = l; 

            width = w;
        }

        public double calculate()
        {
            return length * width;
        }

        public void printName()
        {
            Console.WriteLine("This is a shape");
        }
    }
}
