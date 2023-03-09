using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10090974_OOP_Concepts.Polymorphism
{
    internal class Square : Shape
    {

        public Square(double x) : base(x,0) 
        {
            //length = x;        
        }

        

        public override double calculate()
        {
            return Math.Pow(length,2);
        }
    }
}
