using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates { 
//{
//    using System;

//    // Base class
//    public abstract class Notifier
//    {
//        public event EventHandler<EventArgs> NotificationSent;

//        protected void OnNotificationSent()
//        {
//            NotificationSent?.Invoke(this, EventArgs.Empty);
//        }
//    }

//    // Derived class
//    public class EmailNotifier : Notifier
//    {
//        public void SendEmail(string to)
//        {
//            Console.WriteLine($"Sending email to {to}");
//            OnNotificationSent(); // Raise event from base class
//        }
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            EmailNotifier emailNotifier = new EmailNotifier();

//            // Subscribe to event defined in base class
//            emailNotifier.NotificationSent += (s, e) =>
//            {
//                Console.WriteLine("Notification event raised!");
//            };

//            emailNotifier.SendEmail("test@example.com");

//        }
//    }
}
