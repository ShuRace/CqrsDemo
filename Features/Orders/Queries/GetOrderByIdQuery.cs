// Features/Orders/Queries/GetOrderByIdQuery.cs
using MediatR;

namespace CqrsDemo.Features.Orders.Queries
{
    public class GetOrderByIdQuery : IRequest<OrderDto>
    {
        public int Id { get; set; }
    }

    public class OrderDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}