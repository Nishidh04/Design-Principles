using System;

namespace Design_Principles.SOLID.InterfaceSegregation
{
    // Focused, role-specific interfaces (small and precise)

    interface IDeveloper
    {
        void WriteCode();
        void DeployCode();
    }

    interface IHR
    {
        void ConductInterview();
        void OnboardEmployee(string name);
    }

    // Concrete implementations only implement what they need

    class SoftwareEngineer : IDeveloper
    {
        public void WriteCode()
        {
            Console.WriteLine("Software Engineer: Writing code...");
        }

        public void DeployCode()
        {
            Console.WriteLine("Software Engineer: Deploying code...");
        }
    }

    class Hr: IHR
    {
        public void ConductInterview()
        {
            Console.WriteLine("HR: Conducting interview...");
        }

        public void OnboardEmployee(string name)
        {
            Console.WriteLine($"HR: Onboarding {name}...");
        }
    }

    // Demo to show proper segregation
    internal class IspCompliant
    {
        public void RunExample()
        {
            Console.WriteLine("=== ISP COMPLIANT ===");

            IDeveloper dev = new SoftwareEngineer();
            dev.WriteCode();
            dev.DeployCode();

            IHR hr = new Hr();
            hr.ConductInterview();
            hr.OnboardEmployee("Nishidh");
        }
    }
}