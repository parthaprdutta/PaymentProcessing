using PaymentProcessing.BusinessRules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.BusinessRules
{
    public interface IPaymentProcessor
    {
        void Run(Payment payment);
    }
}
