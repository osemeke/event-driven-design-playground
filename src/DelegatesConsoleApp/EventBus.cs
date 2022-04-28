using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleApp
{
    public class EventBus
    {
        private ServicePoint servicePoint;

        public EventBus(ServicePoint servicePoint)
        {
            this.servicePoint = servicePoint;
        }

        // Delegate understanding
        // function/method wrapper as a type 
        // enabling us pass methods around as function/method parameters
        // use for callback method implementation
        private delegate void OnSendDelegate(string message);

        private OnSendDelegate callbacks; // like event type, contains list of callback methods

        public void Send(string message)
        {
            if (callbacks == null) throw new ArgumentNullException();
            servicePoint.Send(message); // for persistence
            callbacks.Invoke(message); // OR callbacks(message);
        }

        public void Subscribe(DisplayScreen s) => callbacks += s.Recieve; // like adding event listners in JavaScript

    }
}
