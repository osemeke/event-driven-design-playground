using MediatR;

namespace CQRSusingMediatR.CQRS.Events.Handlers
{
    public class NotifyEmailsCustomerCreatedEventHandler : INotificationHandler<CustomerCreatedEvent>
    {
        public Task Handle(CustomerCreatedEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"sending emails: customer {notification.CustomerName} joined the queue");

            return Task.CompletedTask;
        }
    }
}
