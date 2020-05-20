using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentProcessing.BusinessRules.ConcreteRules;
using PaymentProcessing.BusinessRules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.Tests.ConcreteRules
{
    [TestClass]
    public class PackingSlipGenerationForShippingTests
    {
        [TestMethod]
        public void IsApplicable_Success_Test()
        {
            var payment = new Payment(new Product(1, "Laptop", BusinessRules.Enums.ProductType.Physical));
            var rule = new CommissionPaymentGeneration(payment);

            var result = rule.IsApplicable();

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void IsApplicable_Failed_Test()
        {
            var payment = new Payment(new Product(1, "Upgradation", BusinessRules.Enums.ProductType.Membership));
            var rule = new CommissionPaymentGeneration(payment);

            var result = rule.IsApplicable();

            Assert.IsFalse(result);
        }
    }
}
