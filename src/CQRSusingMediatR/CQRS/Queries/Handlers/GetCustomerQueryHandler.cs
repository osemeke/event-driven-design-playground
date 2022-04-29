using CQRSusingMediatR.Data;
using CQRSusingMediatR.Models;
using MediatR;

namespace CQRSusingMediatR.CQRS.Queries.Handlers
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, GetCustomerResponse>
    {
        private CustomerRepository _repository;

        public GetCustomerQueryHandler(CustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCustomerResponse> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetCustomer(request.id);
            if (customer == null) throw new ArgumentNullException(nameof(customer));
            return new GetCustomerResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                TicketNumber = customer.TicketNumber,
            };
        }
    }
}
