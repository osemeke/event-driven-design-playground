using MediatR;

namespace CQRSusingMediatR.CQRS.Events.Handlers
{
    public class NotifyScreensCustomerCreatedEventHandler : INotificationHandler<CustomerCreatedEvent>
    {
        public Task Handle(CustomerCreatedEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"signalr add customer {notification.CustomerName} to display");

            return Task.CompletedTask;
        }
    }
}
