using CQRSusingMediatR.CQRS.Commands;
using CQRSusingMediatR.CQRS.Queries;
using CQRSusingMediatR.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSusingMediatR.Controllers
{
    [ApiController]
    [Route("api")]
    public class CustomersController : ControllerBase
    {
        private IMediator _mediator;

        public CustomersController(IMediator mediator) => _mediator = mediator;

        // on the read service/api

        [HttpGet]
        [Route("customers")]
        public async Task<IActionResult> GetCustomers()
        {
            var response = await _mediator.Send(new GetCustomersQuery());
            return Ok(response);
        }

        [HttpGet]
        [Route("customers/{id}")]
        public async Task<IActionResult> GetCustomer(string id)
        {
            var response = await _mediator.Send(new GetCustomerQuery(id));
            return Ok(response);
        }

        // on the write service/api

        [HttpPost]
        [Route("customers")]
        public async Task<IActionResult> CreateCustomer(CreateCustomerRequest customer)
        {
            var response = await _mediator.Send(new CreateCustomerCommand(customer));
            return Ok(response);
        }

    }
}
