using CQRSusingMediatR.Data;
using CQRSusingMediatR.Data.Entities;
using MediatR;

namespace CQRSusingMediatR.CQRS.Commands.Handlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, bool>
    {
        private CustomerRepository _repository;

        public CreateCustomerCommandHandler(CustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateCustomer(new Customer 
            { 
                Name = request.Name,
                TicketNumber = request.TicketNumber,
            });

            return true;
        }
    }
}
