using CQRSusingMediatR.Data;
using CQRSusingMediatR.Models;
using MediatR;

namespace CQRSusingMediatR.CQRS.Queries.Handlers
{
    public class GetCustomersQueryHandler
        : IRequestHandler<GetCustomersQuery, IEnumerable<GetCustomerResponse>>
    {

        private CustomerRepository _repository;

        public GetCustomersQueryHandler(CustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetCustomerResponse>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            var customers = await _repository.GetCustomers();
            if (customers == null) throw new ArgumentNullException(nameof(customers));
            
            return customers.Select(x => new GetCustomerResponse
            {
                Id = x.Id,
                Name = x.Name,
                TicketNumber = x.TicketNumber,
            });
        }
    }
}
