using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleApp
{
    public class EventHandlerEventBus
    {
        private ServicePoint servicePoint;

        public EventHandlerEventBus(ServicePoint servicePoint)
        {
            this.servicePoint = servicePoint;
        }

        // this uses the built in EventHandler<> to avoid declaring a custome delegate
        // I prefer using delegates directly for it flexibility!
        private event EventHandler<string> callbacks;

        public void Send(string message)
        {
            if (callbacks == null) throw new ArgumentNullException();
            servicePoint.Send(message); // for persistence
            callbacks.Invoke(this, message); // OR callbacks(this, message);
        }

        public void Subscribe(DisplayScreen s) => callbacks += s.Recieve; // this line displays error
                                                                          // until I added the overload Recieve(object sender, string message)
                                                                          // in DisplayScreen class

    }
}
