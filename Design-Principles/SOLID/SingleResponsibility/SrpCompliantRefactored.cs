using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Principles.SOLID.SingleResponsibility
{
    internal class srpRefactored
    {
        public void RunExample()
        {
            // Creating instances of each responsibility
            var frontend = new FrontendDeveloper();
            var backend = new BackendDeveloper();
            var payroll = new PayrollService();
            var hr = new HrService();
            var notify = new NotificationService();

            Console.WriteLine("=== SRP Compliant Example ===\n");

            // Development work
            frontend.BuildUI();
            backend.BuildApi();

            // HR work
            hr.Onboard("Nishidh");

            // Finance work
            payroll.GenerateSalarySlip("Nishidh", 85000m);

            // Notification
            notify.SendEmail("nishidh@sample.com", "Welcome", "Welcome to the company!");
        }
    }

    // Each class has ONE responsibility only

    // 1) Development responsibility - Frontend
    internal class FrontendDeveloper
    {
        public void BuildUI()
        {
         
        }
    }

    // 2) Development responsibility - Backend
    internal class BackendDeveloper
    {
        public void BuildApi()
        {
            
        }
    }

    // 3) Finance / Payroll responsibility
    internal class PayrollService
    {
        public void GenerateSalarySlip(string employeeName, decimal amount)
        {
            
        }
    }

    // 4) HR Responsibility
    internal class HrService
    {
        public void Onboard(string employeeName)
        {
           
        }
    }

    // 5) Notification Responsibility
    internal class NotificationService
    {
        public void SendEmail(string to, string subject, string body)
        {
            
        }
    }
}