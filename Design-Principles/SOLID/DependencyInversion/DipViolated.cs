using System;

namespace Design_Principles.SOLID.DependencyInversion
{
    // High-level module depends directly on concrete services
    internal class DipViolated
    {
        public void RunExample()
        {
            //Console.WriteLine("=== DIP VIOLATED ===");
            var hrSlack = new HROnboarding_Bad();
            hrSlack.OnboardEmployeeWithSlack("Salil");
        }
    }

    // High-level module tightly coupled to specific implementations
    internal class HROnboarding_Bad
    {
        

        public void OnboardEmployeeWithSlack(string name)
        {
            Console.WriteLine($"HR: Onboarding {name}");
            var slack = new SlackNotificationService();    // direct dependency
            slack.Send($"Welcome {name}!");                
        }
    }

    // Low-level concrete classes

    internal class SlackNotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Slack: " + message);
        }
    }
}