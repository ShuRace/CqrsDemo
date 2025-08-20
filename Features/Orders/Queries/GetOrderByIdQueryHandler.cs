// Features/Orders/Queries/GetOrderByIdQueryHandler.cs
using MediatR;
using Microsoft.EntityFrameworkCore;
using CqrsDemo.Data;

namespace CqrsDemo.Features.Orders.Queries
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, OrderDto>
    {
        private readonly ApplicationDbContext _context;

        public GetOrderByIdQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<OrderDto> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await _context.Orders
                .Where(o => o.Id == request.Id)
                .Select(o => new OrderDto
                {
                    Id = o.Id,
                    ProductName = o.ProductName,
                    Price = o.Price,
                    CreatedAt = o.CreatedAt
                })
                .FirstOrDefaultAsync(cancellationToken);

            return order ?? throw new Exception("Order not found");
        }
    }
}