using CQRSusingMediatR.Models;
using MediatR;

namespace CQRSusingMediatR.CQRS.Queries
{
    public class GetCustomersQuery : IRequest<IEnumerable<GetCustomerResponse>>
    {

    }
}
