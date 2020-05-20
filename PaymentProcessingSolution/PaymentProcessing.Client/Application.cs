using PaymentProcessing.BusinessRules;
using PaymentProcessing.BusinessRules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.Client
{
    public class Application : IApplication
    {
        private readonly IPaymentProcessor _processor;
        public Application(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessPayment(Payment payment)
        {
            _processor.Run(payment);
        }
    }
}
