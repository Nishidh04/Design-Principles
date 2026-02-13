using System;

namespace Design_Principles.SOLID.OpenClosed
{
    internal class OcpRefactored
    {
        public void RunExample()
        {
            //OCP Refactored: Adding new employee types does NOT require changes to SalaryCalculator
            SalaryCalculator calculator = new SalaryCalculator();

            Employee fullTime = new FullTimeEmployee();
            Employee partTime = new PartTimeEmployee();
            Employee intern = new InternEmployee();

            Console.WriteLine(calculator.Calculate(fullTime));
            Console.WriteLine(calculator.Calculate(partTime));
            Console.WriteLine(calculator.Calculate(intern));
        }
    }

    // Abstraction — Base class (closed for modification)
    internal abstract class Employee
    {
        public abstract decimal GetSalary();
    }

    // New behavior by adding a new class (open for extension)
    internal class FullTimeEmployee : Employee
    {
        public override decimal GetSalary() => 50000;
    }

    internal class PartTimeEmployee : Employee
    {
        public override decimal GetSalary() => 30000;
    }

    internal class InternEmployee : Employee
    {
        public override decimal GetSalary() => 10000;
    }

    // Salary calculator does NOT change when new types are added
    internal class SalaryCalculator
    {
        public decimal Calculate(Employee emp)
        {
            return emp.GetSalary();
        }
    }
}