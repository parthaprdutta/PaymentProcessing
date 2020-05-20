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
    public class DuplicatepackingSlipGeneration : IRule
    {
        private readonly Payment _payment;
        public DuplicatepackingSlipGeneration(Payment payment)
        {
            _payment = payment;
        }
        public void Execute()
        {
            Console.WriteLine("A duplicate packing slip is created for the royalty department");
        }

        public bool IsApplicable()
        {
            return _payment.Product.ProductType == ProductType.Book;
        }
    }
}
