using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10090974_OOP_Concepts.Encapsulation
{
    internal class CarTester
    {
        static void Main(string[] args)
        {
            string x = "VW_Polo";
            Car  c = new Car(x);
            c.startEngine();
            c.driveCar();
            c.SpeedUp();
            c.SpeedUp();
            c.SpeedUp();
            c.SpeedUp();

            c.Dashboard();
            Console.ReadLine();
        }
    }
}
