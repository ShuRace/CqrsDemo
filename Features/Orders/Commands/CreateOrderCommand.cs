using MediatR;

namespace CqrsDemo.Features.Orders.Commands
{
    public class CreateOrderCommand : IRequest<int>
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }  

    }
}