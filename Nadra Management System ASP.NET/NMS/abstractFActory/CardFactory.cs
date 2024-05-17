using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NMS.abstractFActory
{
    public class MasterCardFactory : IPaymentFactory
    {
        public IPaymentType PaymentType()
        {
            return new Card();
        }
        public virtual IPaymentTypeService PaymentTypeService()
        {
            return new Master();
        }
        
    }
    public class VisaCardFactory: MasterCardFactory
    {
        public override IPaymentTypeService PaymentTypeService()
        {
            return new Visa();
        }

    }
    public class PaypakCardFactory : MasterCardFactory
    {
        public override IPaymentTypeService PaymentTypeService()
        {
            return new Paypak();
        }

    }
}