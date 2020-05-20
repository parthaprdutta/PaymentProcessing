using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.BusinessRules.Models
{
    public class Payment
    {
        public Payment(Product product)
        {
            Product = product;
        }
        public int Id { get; set; }
        public bool IsSuccess { get; set; }
        public Product Product { get; set; }
    }
}
