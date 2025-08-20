// Controllers/OrdersController.cs
using Microsoft.AspNetCore.Mvc;
using MediatR;
using CqrsDemo.Features.Orders.Commands;
using CqrsDemo.Features.Orders.Queries;

namespace CqrsDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
        {
            var orderId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetOrderById), new { id = orderId }, orderId);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var query = new GetOrderByIdQuery { Id = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}