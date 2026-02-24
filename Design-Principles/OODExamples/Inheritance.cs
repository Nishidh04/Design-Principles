using System;

namespace Design_Principles.OODExamples.InheritanceDemo
{
    internal class Inheritance
    {
        public void RunExample()
        {
            Car myCar = new Car();
            myCar.Start();
            myCar.PlayMusic();
            myCar.Stop();
        }
    }

    internal class Vehicle
    {
        public void Start() => Console.WriteLine("Vehicle is starting... Vehicle is trying to move   modified the filenkjefbi");
        public void Stop() => Console.WriteLine("Vehicle is stopping...  Vehicle is trying to move hvhxycx jgvutuvhv");
    }

    internal class Car : Vehicle
    {
        public void PlayMusic() => Console.WriteLine("Playing music in the car.");
    }
}
