using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NMS.brige_Method;

namespace NMS.brige_Method
{
    public class ALhahbi_payment_system: I_Payment_System
    {
        public string ProcessPayment(string paymentSystem)
        {
            return "Using AlHabib getway for" + paymentSystem;
        }

    }
}