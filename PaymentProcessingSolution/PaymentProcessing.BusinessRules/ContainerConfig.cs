using Autofac;
using PaymentProcessing.BusinessRules.Models;
using PaymentProcessing.BusinessRules.Rules;
using PaymentProcessing.BusinessRules.Rules.ConcreteRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.BusinessRules
{
    
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.Register((c, p) => new CommissionPaymentGeneration(p.TypedAs<Payment>())).As<IRule>();
            builder.Register((c, p) => new DuplicatepackingSlipGeneration(p.TypedAs<Payment>())).As<IRule>();
            builder.Register((c, p) => new FreeFirstAidVideo(p.TypedAs<Payment>())).As<IRule>();
            builder.Register((c, p) => new MembershipActivation(p.TypedAs<Payment>())).As<IRule>();
            builder.Register((c, p) => new MembershipEmail(p.TypedAs<Payment>())).As<IRule>();
            builder.Register((c, p) => new MembershipUpgradation(p.TypedAs<Payment>())).As<IRule>();
            builder.Register((c, p) => new PackingSlipGenerationForShipping(p.TypedAs<Payment>())).As<IRule>();
            builder.Register((c, p) => new DefaultRule(p.TypedAs<Payment>())).As<IRule>();

            return builder.Build();
        }

    }   
    
}
