using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Principles.KissAndDry
{
    internal class DryPrinciple
    {
        public void RunExample()
        {
            // INPUT: Two Fahrenheit temperatures
            double fah1 = 98.6; 
            double fah2 = 32;   

            // Reuse the same conversion function (DRY)
            double cel1 = FahrenheitToCelsius(fah1);
            double cel2 = FahrenheitToCelsius(fah2);

            // OUTPUT
            Console.WriteLine($"Fahrenheit: {fah1} -> Celsius: {cel1:0.00}");
            Console.WriteLine($"Fahrenheit: {fah2} -> Celsius: {cel2:0.00}");
        }

        // DRY: Single function for the conversion logic
        private double FahrenheitToCelsius(double fah)
        {
            return (fah - 32) * 5.0 / 9.0;
        }
    }
}