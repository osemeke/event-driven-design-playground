using MediatR;

namespace CQRSusingMediatR.CQRS.Events
{
    public class CustomerCreatedEvent : INotification
    {
        public string CustomerName { get; set; }
    }
}
