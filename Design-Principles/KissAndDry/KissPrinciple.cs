using System;

namespace Design_Principles.KissAndDry
{
    internal class KissPrinciple
    {
        public void RunExample()
        {
            Console.WriteLine("---- WITHOUT KISS ----");
            KissBadExample();

            Console.WriteLine("\n---- WITH KISS ----");
            KissGoodExample();
        }

        
        // Function calls another function just to do a simple calculation
        private void KissBadExample()
        {
            double number = 5;

            // This method calls another method unnecessarily
            double square = CalculateSquare(number);

            Console.WriteLine($"Square (Bad Version): {square}");
        }

        private double CalculateSquare(double num)
        {
            // This is unnecessary — the multiplication could be done directly
            return Multiply(num, num);
        }

        private double Multiply(double a, double b)
        {
            return a * b;
        }


        // ✔ KISS VERSION (Simple & Direct)
        private void KissGoodExample()
        {
            double number = 5;

            // Simple, direct calculation — easiest to understand
            double square = number * number;

            Console.WriteLine($"Square (KISS Version): {square}");
        }
    }
}