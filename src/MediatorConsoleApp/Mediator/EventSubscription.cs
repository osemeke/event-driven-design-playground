using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorConsoleApp.Mediator
{
    internal class EventSubscription
    {
        public string @Event { get; set; }
        public ISubscriber Subscriber { get; set; }
    }
}
