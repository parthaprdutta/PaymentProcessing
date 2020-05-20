using Autofac;
using PaymentProcessing.BusinessRules.Models;
using PaymentProcessing.BusinessRules.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.BusinessRules.Rules
{
    public class RuleFactory
    {
        public static IEnumerable<IRule> GetRules(Payment payment)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var rules = scope.Resolve<IEnumerable<IRule>>(new TypedParameter(typeof(Payment), payment));

                return rules;
            }
        }
    }
}
