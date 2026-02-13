using System;

namespace Design_Principles.SOLID.DependencyInversion
{
    internal class DipRefactored
    {
        public void RunExample()
        {
            //Console.WriteLine("=== DIP COMPLIANT ===");

            // Easily switch the notification mechanism by changing the injected implementation
            INotificationService email = new EmailService();
            INotificationService slack = new SlackNotificationServices();

            var hrUsingEmail = new HROnboarding(email);
            hrUsingEmail.OnboardEmployee("Nishidh");

            var hrUsingSlack = new HROnboarding(slack);
            hrUsingSlack.OnboardEmployee("Salil");
        }
    }

    // Abstraction that high- and low-level modules depend on
    internal interface INotificationService
    {
        void Send(string message);
    }

    // High-level module depends on abstraction (constructor injection)
    internal class HROnboarding
    {
        private readonly INotificationService _notification;

        public HROnboarding(INotificationService notification)
        {
            _notification = notification;
        }

        public void OnboardEmployee(string name)
        {
            Console.WriteLine($"HR: Onboarding {name}");
            _notification.Send($"Welcome {name}!");
        }
    }

    // Low-level implementations (details) — can be swapped freely

    internal class EmailService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }

    internal class SlackNotificationServices : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Slack: " + message);
        }
    }

    // Add more implementations without modifying HROnboarding
    internal class SmsService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS: " + message);
        }
    }
}