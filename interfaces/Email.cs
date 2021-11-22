using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public class Email : IMessage
    {
        public void Notification()
        {
            Console.WriteLine("Mail");
        }
    }
}
