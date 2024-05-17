using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NMS.brige_Method
{
    public abstract class Payment
    {
        public I_Payment_System _IPaymentSystem;
        public abstract void MakePayment();

    
    }
}