using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static NMS.abstractFActory.payment_abstract_factory;

namespace NMS.abstractFActory
{
    public class Cash : IPaymentType
    {
        public string getPaymentType() 
        {
            return PaymentType.Cash.ToString();
        }
    }
    public class Card : IPaymentType
    {
        public string getPaymentType()
        {
            return PaymentType.Card.ToString();
        }
    }
}