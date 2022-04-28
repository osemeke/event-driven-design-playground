using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ServicePoint : IClinicPublisher
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public void Send(string message)
        {
            Console.WriteLine($"Service point {this.Name} sent message: {message}");
        }

    }
}
