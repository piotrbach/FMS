using System;

namespace FMS.Api.Models
{
    public class CreateCustomerRequest
    {
        /// <summary>
        /// From external system
        /// </summary>
        public string AccountNumber { get; set; }
        
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdNumber { get; set; }
        public string PhoneNumber { get; set; }
    }
}