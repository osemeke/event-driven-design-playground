using Data.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleApp
{
    public class GenericEventBus<P, S>
        where P : IClinicPublisher
        where S : IClinicSubscriber
    {
        private P _publisher;

        public GenericEventBus(P publisher)
        {
            this._publisher = publisher;
        }

        // Delegate understanding
        // function/method wrapper as a type 
        // enabling us pass methods around as function/method parameters
        // use for callback method implementation
        private delegate void OnSendDelegate(string message);

        private OnSendDelegate callbacks; // like event type

        public void Send(string message)
        {
            if (callbacks == null) throw new ArgumentNullException();
            _publisher.Send(message); // for persistence
            callbacks.Invoke(message); // OR callbacks(message);
        }

        public void Subscribe(S s) => callbacks += s.Recieve; // like adding event listners in JavaScript
    }
}
