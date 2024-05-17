using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NMS.brige_Method;

namespace NMS.brige_Method
{
    public class CardPayment: Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayment("Card payment");
        }
    }
}