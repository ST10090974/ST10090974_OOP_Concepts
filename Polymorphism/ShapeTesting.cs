using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10090974_OOP_Concepts.Polymorphism
{
    internal class ShapeTesting
    {
        static void Main(string[] args)
        {
            double x = 7;
            double y = 7;

            Shape sha = new Shape(x, y);
            Console.WriteLine("Area: " + sha.calculate());

            Square sq = new Square(5);
            Console.WriteLine("Area: " + sq.calculate());

            Circle ci = new Circle(8);
            Console.WriteLine("Area: " + ci.calculate());
            Console.ReadLine();
        }
    }
}
