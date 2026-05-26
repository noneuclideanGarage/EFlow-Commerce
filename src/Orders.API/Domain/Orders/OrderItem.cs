
public class OrderItem
{
    private OrderItem() 
    {
        Id = Guid.CreateVersion7();
    }

    public OrderItem(Guid productId, uint quantity, uint unitPrice)
    {
        if (quantity == 0)
            throw new InvalidDataException("Quantity of OrderItem should be greater then 0");
        if (unitPrice == 0)
            throw new InvalidDataException("UnitPrice of OrderItem should be greater then 0");
        if (ProductId == Guid.Empty)
            throw new InvalidDataException("ProductId of OrderItem must have an Id");

        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    public Guid Id { get; init; }
    public Guid ProductId { get; init; } 
    public uint Quantity { get; set; } 
    public uint UnitPrice { get; set; }
    public ulong TotalPrice => Quantity * UnitPrice;
}
