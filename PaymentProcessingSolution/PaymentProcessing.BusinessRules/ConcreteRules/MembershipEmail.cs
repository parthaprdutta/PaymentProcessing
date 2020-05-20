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
    public class MembershipEmail : IRule
    {
        private readonly Payment _payment;
        public MembershipEmail(Payment payment)
        {
            _payment = payment;
        }
        public void Execute()
        {
            Console.WriteLine($"Email sent to owner for {_payment.Product.Name}");
        }

        public bool IsApplicable()
        {
            return _payment.Product.ProductType == ProductType.Membership;
        }
    }
}
