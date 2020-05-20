using Autofac;
using PaymentProcessing.BusinessRules.Enums;
using PaymentProcessing.BusinessRules.Models;
using System;

namespace PaymentProcessing.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payment(new Product(1, "Microservices", ProductType.Book));

            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var application = scope.Resolve<IApplication>();
                application.ProcessPayment(payment);
            }
        }
    }
}
