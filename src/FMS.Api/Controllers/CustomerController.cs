using System;
using FMS.Api.Models.Requests;
using FMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace FMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }
        
        // GET: api/Customer
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_customerService.GetAll());
        }
        
        // POST: api/Customer
        [HttpPost]
        public ActionResult Save([FromBody] CreateCustomerRequest request)
        {
            return Ok($"Customer {request.IdNumber} created");
        }
    }
}
