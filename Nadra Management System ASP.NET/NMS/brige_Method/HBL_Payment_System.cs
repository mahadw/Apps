using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NMS.brige_Method;

namespace NMS.brige_Method
{
    public class HBL_Payment_System :I_Payment_System
    {
    

        public string ProcessPayment(string paymentSystem)
        {
            return "using HBL Geteway for " + paymentSystem;
        }
    }
}