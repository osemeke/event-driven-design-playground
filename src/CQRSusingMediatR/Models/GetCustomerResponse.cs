namespace CQRSusingMediatR.Models
{
    public class GetCustomerResponse : CreateCustomerRequest
    {
        public string Id { get; set; }
    }
}
