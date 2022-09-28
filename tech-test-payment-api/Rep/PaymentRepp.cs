using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tech_test_payment_api.Models;
namespace tech_test_payment_api.Rep
{
    public interface PaymentRepp
    {
        PaymentModels Register(PaymentModels payment);
        PaymentModels Update(PaymentModels payment);
        PaymentModels ListById(int id);
    }
}