using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentProcessing.BusinessRules.ConcreteRules;
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
            var rule = new CommissionPaymentGeneration();

            var result = rule.IsApplicable();

            Assert.IsTrue(result);
        }
    }
}
