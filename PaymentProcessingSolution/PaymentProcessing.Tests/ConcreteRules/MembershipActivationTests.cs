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
    public class MembershipActivationTests
    {
        [DataTestMethod]
        [DataRow(3, "Membership activation", ProductType.Membership)]

        public void IsApplicable_Success_Test(int id, string productName, ProductType productType)
        {
            var payment = new Payment(new Product(id, productName, productType));
            var rule = new MembershipActivation(payment);

            var result = rule.IsApplicable();

            Assert.IsTrue(result);
        }


        [DataTestMethod]
        [DataRow(1, "Laptop", ProductType.Physical)]
        [DataRow(5, "Learning to Ski", ProductType.Video)]
        [DataRow(4, "Membership upgradation", ProductType.Membership)]
        [DataRow(2, "Microservices", ProductType.Book)]
        public void IsApplicable_Failed_Test(int id, string productName, ProductType productType)
        {
            var payment = new Payment(new Product(id, productName, productType));
            var rule = new MembershipActivation(payment);

            var result = rule.IsApplicable();

            Assert.IsFalse(result);
        }

    }
}
