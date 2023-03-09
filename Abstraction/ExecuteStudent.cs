using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10090974_OOP_Concepts.Abstraction
{
    internal class ExecuteStudent
    {
        static void Main(string[] args)
        {
            BCADStudent bCADStudent = new BCADStudent();
            bCADStudent.registerForCource();
            bCADStudent.ICETask();
            bCADStudent.getName();
            Console.ReadLine(); 
        }
    }
}
