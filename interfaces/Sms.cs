﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Sms : IMessage
    {
        public void Notification()
        {
            Console.WriteLine("SMS");
        }
    }
}
