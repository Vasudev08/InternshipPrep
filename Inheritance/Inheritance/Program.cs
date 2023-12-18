using System;

namespace Program
{
    class Inheritance
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            //1. Base Class - Derived Class
            //2. Constructor
            //3. Casting
            //4. Sealed
            //5. Inheriting an inherited class


            var car = new Car();

            var Ferrari = new Ferrari();
        }
    }



    public class Car
    {
        public int WheelSize { get; set; }
        public int NumberofDoors { get; set; }

        public Car()
        {
        }
    }


    public class Ferrari : Car
    {
        public Ferrari(int wheelSize)
        {
            WheelSize = wheelSize;

        }

    }

    // NO heritating multiple classes, we can only one class inheritaned
}