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
    public class FreeFirstAidVideo : IRule
    {
        private readonly Payment _payment;
        public FreeFirstAidVideo(Payment payment)
        {
            _payment = payment;
        }
        public void Execute()
        {
            Console.WriteLine("Free First-Aid video added to the packing slip.");
        }

        public bool IsApplicable()
        {
            return _payment.Product.ProductType == ProductType.Video
                && _payment.Product.Name == Constant.LEARNING_TO_SKI;
        }
    }
}
