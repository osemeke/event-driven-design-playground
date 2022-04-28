using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorConsoleApp.Mediator
{
    internal class ServiceBusMediator : IMediator
    {
        private List<EventSubscription> subscriptions = new List<EventSubscription>();

        public void Subscribe(EventSubscription subscription) => subscriptions.Add(subscription);

        public void Publish(string @event, string message)
        {
            var subscribers = subscriptions.Where(s => s.Event == @event).ToList();
            foreach (EventSubscription sub in subscribers)
            {
                sub.Subscriber.Handle(message);
            }
        }
    }
}
