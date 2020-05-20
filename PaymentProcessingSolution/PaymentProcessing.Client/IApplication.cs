using PaymentProcessing.BusinessRules.Models;

namespace PaymentProcessing.Client
{
    public interface IApplication
    {
        void ProcessPayment(Payment payment);
    }
}