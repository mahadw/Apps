﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static NMS.abstractFActory.payment_abstract_factory;

namespace NMS.abstractFActory
{
    public class Master: IPaymentTypeService
    {
        public string GetPaymentTypeService() 
        {
            return PaymentTypeService.Master.ToString();
        }
    }
}