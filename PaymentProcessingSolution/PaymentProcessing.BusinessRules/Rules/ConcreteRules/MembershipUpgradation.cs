using PaymentProcessing.BusinessRules.Constants;
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
    public class MembershipUpgradation : IRule
    {
        private readonly Payment _payment;
        public MembershipUpgradation(Payment payment)
        {
            _payment = payment;
        }
        public void Execute()
        {
            Console.WriteLine("Membership upgraded");
        }

        public bool IsApplicable()
        {
            return _payment.Product.ProductType == ProductType.Membership
                && _payment.Product.Name == Constant.MEMBERSHIP_UPGRADATION;
        }
    }
}
