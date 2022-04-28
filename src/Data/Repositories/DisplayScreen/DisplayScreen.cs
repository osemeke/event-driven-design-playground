using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class DisplayScreen : IClinicSubscriber
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public void Recieve(string message) 
        { 
            Console.WriteLine($"screen {Name} displayed {message}");
            // trigger SignalR here to send message to the web UI
        }
    }
}
