using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorConsoleApp.Mediator
{
    internal interface IMediator
    {
        void Subscribe(EventSubscription subscription);
        void Publish(string @event, string message);
    }
}
