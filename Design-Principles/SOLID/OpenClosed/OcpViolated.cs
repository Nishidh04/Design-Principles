using System;

namespace Design_Principles.SOLID.OpenClosed
{
    
    
    internal class OcpViolated
    {
        public void RunExample()
        {
            var calc = new SalaryCalculator_Bad();

            Console.WriteLine(calc.CalculateSalary("FullTime"));
            Console.WriteLine(calc.CalculateSalary("PartTime"));
            Console.WriteLine(calc.CalculateSalary("Intern")); 
        }
    }

    // Class is NOT closed for modification
    internal class SalaryCalculator_Bad
    {
        public decimal CalculateSalary(string employeeType)
        {
            // If-else or switch breaks OCP:
            // You must modify this method every time you add a new employee type.
            if (employeeType == "FullTime")
                return 50000;

            if (employeeType == "PartTime")
                return 30000;

            if (employeeType == "Intern")
                return 10000;

            // Adding new employee types requires MODIFYING this class (violates OCP)
            return 0;
        }
    }
}