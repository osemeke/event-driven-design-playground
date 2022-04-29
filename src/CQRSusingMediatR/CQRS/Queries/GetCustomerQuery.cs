using CQRSusingMediatR.Models;
using MediatR;

namespace CQRSusingMediatR.CQRS.Queries
{
    public class GetCustomerQuery : IRequest<GetCustomerResponse>
    {
        public string id { get;}

        public GetCustomerQuery(string id)
        {
            this.id = id;
        }
    }
}
