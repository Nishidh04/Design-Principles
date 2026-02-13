using System;

namespace Design_Principles.SOLID.LiskovSubstitution
{

    // Use role-specific abstractions so any implementation can be substituted without surprises.

    internal class LspRefactored
    {
        public void RunExample()
        { 

            IDeveloper dev1 = new SoftwareEngineerDev();


            // Any IDeveloper can be substituted here safely
            DeployFeature(dev1);


            // Finance flow uses IFInance; substitution is safe within that boundary
            IFinance fin1 = new FinanceOfficerDev();

            ProcessPayroll(fin1, "Nishidh", 85000m);

        }

        private void DeployFeature(IDeveloper developer)
        {
            developer.WriteCode();
            developer.Deploy();
            
        }

        private void ProcessPayroll(IFinance finance, string employeeName, decimal amount)
        {
            finance.GenerateSalarySlip(employeeName, amount);
            
        }
    }

    // Role-specific abstractions keep contracts tight, safe substitution

    internal interface IDeveloper
    {
        void WriteCode();
        void Deploy();
    }

    internal interface IFinance
    {
        void GenerateSalarySlip(string employeeName, decimal amount);
    }

    internal class SoftwareEngineerDev : IDeveloper
    {
        public void WriteCode() { }
        public void Deploy() { }
    }

    internal class FinanceOfficerDev : IFinance
    {
        public void GenerateSalarySlip(string employeeName, decimal amount)
            => Console.WriteLine($"Salary slip for {employeeName} of ₹{amount:0.00} generated.");
    }


}