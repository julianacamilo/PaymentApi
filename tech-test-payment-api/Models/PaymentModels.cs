using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api.Models
{
    public class PaymentModels 
    {
         public string? Name { get; set; }
        public string? TaxRoll{ get; set; }
        public string? Mail { get; set; }
        public string? Cellphone { get; set; }
        public string[]? SaledItems { get; set; }
        public DateTime Date { get; set; }
    }
}