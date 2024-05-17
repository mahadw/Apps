using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using  NMS.abstractFActory;

namespace NMS.abstractFActory
{
    public class PaymentSystem
    {
        IPaymentFactory _IPaymentFactory;
        public PaymentSystem (IPaymentFactory iPaymentFactory)
        {
            _IPaymentFactory = iPaymentFactory;
        }

        internal void processpayment(string v)
        {
            throw new NotImplementedException();
        }

        public string GetPaymentdetails()
        {
            IPaymentType PaymentType = _IPaymentFactory.PaymentType();
            IPaymentTypeService PaymentTypeService = _IPaymentFactory.PaymentTypeService();
            string returnValue = string.Format("{0}{1}", PaymentType.getPaymentType(), PaymentTypeService.GetPaymentTypeService());
            return returnValue;
        }
    }
}