using PaymentProcessing.BusinessRules.Models;
using PaymentProcessing.BusinessRules.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.BusinessRules
{
    public class RuleProcessor
    {
        public void Run(Payment payment)
        {
            var rules = RuleFactory.GetRules(payment);
            var evaaluator = new RuleEvaluator(rules);
            evaaluator.ExecuteRules();
        }
    }
}
