using CQRSusingMediatR.Models;
using MediatR;

namespace CQRSusingMediatR.CQRS.Commands
{
    public class CreateCustomerCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string TicketNumber { get; set; }

        public CreateCustomerCommand(CreateCustomerRequest request)
        {
            this.Name = request.Name;
            this.TicketNumber = request.TicketNumber;
        }
    }
}
