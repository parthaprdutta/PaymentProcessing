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
    public class CommissionPaymentGenerationTests
    {
        [TestMethod]
        public void IsApplicable_Success_Test()
        {
            var payment = new Payment(new Product(1, "Microservices", BusinessRules.Enums.ProductType.Book));
            var rule = new CommissionPaymentGeneration(payment);

            var result = rule.IsApplicable();

            Assert.IsTrue(result);
        }
    }
}
