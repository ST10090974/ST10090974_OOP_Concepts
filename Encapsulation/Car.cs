using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10090974_OOP_Concepts.Encapsulation
{
    internal class Car
    {
        //private int x;

        //public int GetX()
        //{
        //    return x;
        //}
        //public void SetX(int anotheX) { }

        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        private int fuel;
        private int speed;
        private string carName;


        public Car(string name)
        {
            this.carName = name;
            fuel= 250;
            speed = 0;
        }
        public void startEngine()
        {
            TurnMotor();
            Console.WriteLine("Vroom!!!");
        }

        public void driveCar()
        {
            SpeedUp();
            Console.WriteLine("Drive!!!");
        }
        public void SpeedUp() 
        {
            fuel-=10;
            speed+=15;
        }

        private void BurnFuel()
        {
            --fuel;
        }

        private void TurnMotor()
        {
            BurnFuel();
        }

        public int GetSpeed()
        {
            return speed;
        }
        public int GetFuel()
        {
            return fuel;
        }

        public void Dashboard()
        {
            Console.WriteLine($"{carName} Driving at {speed}km/h with {fuel}L");
        }
    }
}
