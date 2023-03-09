using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10090974_OOP_Concepts.Polymorphism
{
    internal class Shape
    {
        protected double length;
        protected double width;

        public Shape()
        {
        }

        public Shape(double l, double w)
        {
            length = l; 

            width = w;
        }

        public virtual double calculate()
        {
            return length * width;
        }

        public void printName()
        {
            Console.WriteLine("This is a shape");
        }
    }
}
