using CQRSusingMediatR.Data.Entities;

namespace CQRSusingMediatR.Data
{
    public class CustomerRepository
    {
        List<Customer> customers = new List<Customer>();

        public CustomerRepository()
        {
            //seeding
            customers.Add(new Customer 
            { 
                Id = Guid.NewGuid().ToString(), 
                Name = "ANENE CHUKWUEBUKA IFEATU", 
                TicketNumber = "124583" 
            });
        }

        public async Task<Customer> GetCustomer(string id)
        {
            var customers = await GetCustomers();
            return customers.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await Task.FromResult(customers);
        }

        public async Task<bool> CreateCustomer(Customer customer)
        {
            customers.Add(new Customer 
            { 
                Id = Guid.NewGuid().ToString(), 
                Name = customer.Name, 
                TicketNumber = customer.TicketNumber
            });
            return await Task.FromResult(true);
        }
    }
}
