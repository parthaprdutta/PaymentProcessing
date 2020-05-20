using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentProcessing.BusinessRules.ConcreteRules;
using PaymentProcessing.BusinessRules.Enums;
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
        [DataTestMethod]
        [DataRow(1, "Laptop", ProductType.Physical)]
        [DataRow(2, "Microservices", ProductType.Book)]
        
        public void IsApplicable_Success_Test(int id, string productName, ProductType productType)
        {
            var payment = new Payment(new Product(id, productName, productType));
            var rule = new CommissionPaymentGeneration(payment);

            var result = rule.IsApplicable();

            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow(3, "Membership activation", ProductType.Membership)]
        [DataRow(4, "Membership upgradation", ProductType.Membership)]
        [DataRow(5, "Learning to Ski", ProductType.Video)]
        public void IsApplicable_Failed_Test(int id, string productName, ProductType productType)
        {
            var payment = new Payment(new Product(id, productName, productType));
            var rule = new CommissionPaymentGeneration(payment);

            var result = rule.IsApplicable();

            Assert.IsFalse(result);
        }
    }
}
