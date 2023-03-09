using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10090974_OOP_Concepts.Abstraction
{
    internal class BCADStudent: Student
    {
        public override void registerForCource()
        {
            Console.WriteLine("Registered for BCAD.");
        }

        public void ICETask()
        {
            Console.WriteLine("PROG7311 ICE Task due Friday 10 March 2023.");
        }
    }
}
