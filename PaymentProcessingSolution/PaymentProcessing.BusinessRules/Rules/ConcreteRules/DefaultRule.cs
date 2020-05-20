using PaymentProcessing.BusinessRules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.BusinessRules.Rules.ConcreteRules
{
    public class DefaultRule : IRule
    {
        private readonly Payment _payment;
        public DefaultRule(Payment payment)
        {
            _payment = payment;
        }
        public void Execute()
        {
            Console.WriteLine("This is the default rule.");
        }
        public bool IsApplicable()
        {
            return true;
        }
    }
}
