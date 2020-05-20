using PaymentProcessing.BusinessRules.Enums;
using PaymentProcessing.BusinessRules.Models;
using PaymentProcessing.BusinessRules.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.BusinessRules.ConcreteRules
{
    public class PackingSlipGenerationForShipping : IRule
    {
        private readonly Payment _payment;
        public PackingSlipGenerationForShipping(Payment payment)
        {
            _payment = payment;
        }
        public void Execute()
        {
            Console.WriteLine("Packing slip generated for shipping.");
        }

        public bool IsApplicable()
        {
            return _payment.Product.ProductType == ProductType.Physical;
        }
    }
}
