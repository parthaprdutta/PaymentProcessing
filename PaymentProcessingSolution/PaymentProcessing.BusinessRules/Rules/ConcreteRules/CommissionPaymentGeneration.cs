using PaymentProcessing.BusinessRules.Enums;
using PaymentProcessing.BusinessRules.Models;
using PaymentProcessing.BusinessRules.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.BusinessRules.Rules.ConcreteRules
{
    public class CommissionPaymentGeneration : IRule
    {
        private readonly Payment _payment;
        public CommissionPaymentGeneration(Payment payment)
        {
            _payment = payment;
        }
        public void Execute()
        {
            Console.WriteLine("Commission payment to the agent is generated");
        }

        public bool IsApplicable()
        {
            return _payment.Product.ProductType == ProductType.Physical
                || _payment.Product.ProductType == ProductType.Book;
        }
    }
}
