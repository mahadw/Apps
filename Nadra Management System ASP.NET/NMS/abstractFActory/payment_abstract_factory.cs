using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NMS.abstractFActory
{
    public class payment_abstract_factory
    {
        public enum PaymentType
        {
            Cash,
            Card
        }
        public enum PaymentTypeService
        {
            Currency,
            Master,
            Visa,
            Paypak
        }
    }
}