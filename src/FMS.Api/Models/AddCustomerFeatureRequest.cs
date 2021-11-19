namespace FMS.Api.Models
{
    public class AddCustomerFeatureRequest
    {
        public string ProductId { get; set; }
        public string CustomerId { get; set; }
        public string ShopId { get; set; }
        public decimal TotalLoanAmount { get; set; }
        public decimal DailyRate { get; set; }
    }
}