using PaymentProcessing.BusinessRules.Models;

namespace PaymentProcessing.Client
{
    internal interface IApplication
    {
        void ProcessPayment(Payment payment);
    }
}