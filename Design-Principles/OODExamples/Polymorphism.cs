using System;

namespace Design_Principles.OODExamples.PolymorphismDemo
{
    internal class Polymorphism
    {
        public void RunExample()
        {
            Vehicle v1 = new Car();
            Vehicle v2 = new Bike();

            // Overriding (runtime polymorphism) 
            v1.Drive();
            v2.Drive();

            //  Overriding with overloaded version 
            v1.Drive(10);
            v2.Drive(5);

            // Overloading (compile-time polymorphism) 
            Car car = new Car();
            car.Drive("eco");
            car.Drive("sport");
            car.Drive(25);
            car.Drive();
        }
    }

    // Base class
    internal class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("The vehicle is driving.");
        }

        public virtual void Drive(int kilometers)
        {
            Console.WriteLine($"The vehicle is driving for {kilometers} km.");
        }
    }

    // Derived class #1
    internal class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("The car is driving smoothly.");
        }

        public override void Drive(int kilometers)
        {
            Console.WriteLine($"The car is cruising for {kilometers} km.");
        }

        // Overloading (simplified) 
        public void Drive(string mode)
        {
            Console.WriteLine($"The car is driving in mode: {mode}");
        }
    }

    // Derived class #2
    internal class Bike : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("The bike is driving fast.");
        }
    }
}