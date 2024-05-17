using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMS.abstractFActory
{
    public interface IPaymentFactory
    {
        IPaymentType PaymentType();
        IPaymentTypeService PaymentTypeService();
        
    }
}
