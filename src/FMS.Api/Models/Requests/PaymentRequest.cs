namespace FMS.Api.Models.Requests
{
    public class PaymentRequest
    {
        public string PhoneNumber { get; set; }
        public string AccountNumber { get; set; }
        public decimal PaymentAmount { get; set; }
    }
}