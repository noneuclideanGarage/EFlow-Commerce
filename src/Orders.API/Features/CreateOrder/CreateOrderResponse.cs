using Orders.API.Domain.Orders;

namespace Orders.API.Features.CreateOrder;

public record CreateOrderResponse(Guid OrderId, OrderStatus Status);
