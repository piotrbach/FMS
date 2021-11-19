using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMS.Api.Models.Requests;
using FMS.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        
        [HttpPost]
        public ActionResult Pay([FromBody] PaymentRequest request)
        {
            return Ok($"Payment {request.PaymentAmount} finished");
        }
    }
}