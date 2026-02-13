using System;

namespace Design_Principles.OODExamples.EncapsulationDemo
{
    internal class Encapsulation
    {
        public void RunExample()
        {
            MobilePhone phone = new MobilePhone();

            phone.UsePhone(20);

            Console.WriteLine($"Final Battery Level: {phone.BatteryLevel}%");
        }
    }

    // Encapsulated class
    internal class MobilePhone
    {
        // Private field (hidden from outside)
        private int _batteryLevel = 50;

        // Public read-only property
        public int BatteryLevel
        {
            get { return _batteryLevel; }
        }

        // Public method to use the phone
        public void UsePhone(int minutes)
        {
            if (minutes <= 0)
            {
                Console.WriteLine("Invalid usage time.");
                return;
            }

            if (_batteryLevel <= 0)
            {
                Console.WriteLine("Battery empty. Please charge the phone.");
                return;
            }

            _batteryLevel -= minutes;

            if (_batteryLevel < 0)
                _batteryLevel = 0;

            Console.WriteLine($"Used phone for {minutes} minutes. Battery: {_batteryLevel}%");
        }

        
        
    }
}