using FMS.Api.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace FMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerFeatureController : ControllerBase
    {
        [HttpPost]
        public ActionResult Save([FromBody] AddCustomerFeatureRequest request)
        {
            return Ok($"Feature for {request.CustomerId} added to account");
        }
    }
}