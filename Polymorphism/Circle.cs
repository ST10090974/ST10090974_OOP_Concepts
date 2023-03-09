using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10090974_OOP_Concepts.Polymorphism
{
    internal class Circle: Shape
    {

        public Circle(double x): base(0, x)
        {

        }

        public override double calculate()
        {
            return Math.PI * (width * width);
        }
    }
}
