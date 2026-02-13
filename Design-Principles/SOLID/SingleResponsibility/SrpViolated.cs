using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Principles.SOLID.SingleResponsibility
{
    // Demo runner to show the SRP violation in action
    internal class SrpViolated
    {
        public void RunExample()
        {
            var ops = new CompanyOperations_Bad();

            ops.BuildFrontend();                          // Dev responsibility
            ops.BuildBackend();                           // Dev responsibility
            ops.GenerateSalarySlip("Nishidh");            // Finance responsibility
            ops.OnboardEmployee("Nishidh");               // HR responsibility
            ops.NotifyEmployee("Nishidh", "Welcome!");    // Communication responsibility
        }
    }

    //SRP VIOLATION: This class has multiple responsibilities (Dev + Finance + HR + Notifications)
    internal class CompanyOperations_Bad
    {
        public void BuildFrontend() => Console.WriteLine("Building UI with React.");
        public void BuildBackend() => Console.WriteLine("Building API with .NET.");
        public void GenerateSalarySlip(string employee) => Console.WriteLine($"Salary slip generated for {employee}.");
        public void OnboardEmployee(string employee) => Console.WriteLine($"Onboarded {employee} with HR formalities.");
        public void NotifyEmployee(string employee, string message) => Console.WriteLine($"Email to {employee}: {message}");
    }
}