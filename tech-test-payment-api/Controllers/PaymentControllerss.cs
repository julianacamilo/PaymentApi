using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tech_test_payment_api.Rep;
using tech_test_payment_api.Models;
namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentControllerss : ControllerBase
    {
        
        private readonly PaymentRepp _paymentRepository;

        public PaymentControllerss(PaymentRepp paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        [HttpGet("Find")]
        public IActionResult Find(int id)
        {
            var payment = _paymentRepository.ListById(id);
            
            return Ok(payment);
        }

        [HttpPost]
        public IActionResult Register(PaymentModels? paymentModel)
        {
            if (paymentModel == null)
            {
                return BadRequest(new { Error = "Payment data can't be null" });
            }

            _paymentRepository.Register(paymentModel);

            return CreatedAtAction(nameof(Find), new {id = paymentModel}, paymentModel);
        }

        [HttpPost]
        public IActionResult Update(PaymentModels? paymentModel)
        {
            if (ModelState.IsValid)
            {
                var payment = new PaymentModels()
                {
                    Name = paymentModel?.Name,
                    Cellphone = paymentModel?.Cellphone,
                    Date = paymentModel.Date,
                    Mail = paymentModel.Mail,
                    SaledItems = paymentModel.SaledItems,
                    TaxRoll = paymentModel.TaxRoll
                };

                payment = _paymentRepository.Update(payment);
                return Ok(payment);
            }
            return Ok();
        }
    };
    }
