using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NMS.brige_Method
{
    public class Onlinepayment:Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayment("Cash payment");
        }
    }
}