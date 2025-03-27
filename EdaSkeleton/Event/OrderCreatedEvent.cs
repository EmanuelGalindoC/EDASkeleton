namespace EdaSkeleton.Event;

public class OrderCreatedEvent : BaseEvent
{
    public string OrderId { get; }
    public string Product { get; }

    public OrderCreatedEvent(string orderId, string product)
    {
        OrderId = orderId;
        Product = product;
    }
}
