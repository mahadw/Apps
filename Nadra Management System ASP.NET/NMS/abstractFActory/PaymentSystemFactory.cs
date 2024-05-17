using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NMS.Models;
using NMS.abstractFActory;

namespace NMS.abstractFActory
{
    public class PaymentSystemFactory
    {
        public IPaymentFactory create (payment_tbl t)
        {
            IPaymentFactory returnValue = null;
            if(t.Payment_id==1)
            {
                if(t.payment_type=="Master")
                {
                    returnValue = new MasterCardFactory();
                }
               else if (t.payment_type == "Visa")
                {
                    returnValue = new VisaCardFactory();
                }
              else  if (t.payment_type == "PayPak")
                {
                    returnValue = new PaypakCardFactory();
                }
               
            }
            else
            {
                returnValue = new Cashfactory();
            }
            return returnValue;

        }
    }
}