using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessage sms = new Sms();
            IMessage email = new Email();

            Notification n_Email = new Notification(email);
            Notification n_SMS = new Notification(sms);

            List<Notification> notifications = new List<Notification>();


            notifications.Add(n_Email);
            notifications.Add(n_SMS);

            for (int i = 0; i < notifications.Count; i++)
            {
                notifications[i].Notify();
            }


            Console.ReadKey();
        }
    }
}
