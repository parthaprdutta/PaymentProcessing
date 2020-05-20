using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.BusinessRules.Rules
{
    public class RuleEvaluator
    {
        private readonly IEnumerable<IRule> _rules;

        public RuleEvaluator(IEnumerable<IRule> rules)
        {
            _rules = rules;
        }

        public void ExecuteRules()
        {
            var validRules = _rules.Where(r => r.IsApplicable());

            if (validRules != null && validRules.Any())
            {
                validRules.ToList().ForEach(r => r.Execute());
            }
        }
    }
}
