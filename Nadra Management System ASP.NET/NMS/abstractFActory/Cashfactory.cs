using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NMS.abstractFActory
{
    public class Cashfactory : IPaymentFactory
    {
        public IPaymentType PaymentType() 
        {
            return new Cash(); 
        }
        public IPaymentTypeService PaymentTypeService()
        {
            return new Currency();
        }


    }
}