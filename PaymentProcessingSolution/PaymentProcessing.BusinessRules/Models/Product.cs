using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentProcessing.BusinessRules.Enums;

namespace PaymentProcessing.BusinessRules.Models
{
    public class Product
    {
        public Product(int id, string name, ProductType productType)
        {
            Id = id;
            Name = name;
            ProductType = productType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
    }
}
