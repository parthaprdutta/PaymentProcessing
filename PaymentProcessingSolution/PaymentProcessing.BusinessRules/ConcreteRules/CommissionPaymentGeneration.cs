using PaymentProcessing.BusinessRules.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.BusinessRules.ConcreteRules
{
    public class CommissionPaymentGeneration : IRule
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public bool IsApplicable()
        {
            return false;
        }
    }
}
