// Features/Orders/Commands/CreateOrderCommandHandler.cs
using MediatR;
using CqrsDemo.Data;
using CqrsDemo.Models;

namespace CqrsDemo.Features.Orders.Commands
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateOrderCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                ProductName = request.ProductName,
                Price = request.Price,
                CreatedAt = DateTime.UtcNow
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync(cancellationToken);
            return order.Id;
        }
    }
}