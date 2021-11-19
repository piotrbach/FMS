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
    public class NotificationHubController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationHubController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        
        [HttpPost]
        public ActionResult SendSms([FromBody] NotificationRequest request)
        {
            throw new NotImplementedException();
        }
        
        [HttpPost]
        public ActionResult SendToDevice([FromBody] NotificationRequest request)
        {
            throw new NotImplementedException();
        }
    }
}