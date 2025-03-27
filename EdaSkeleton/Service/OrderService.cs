using EdaSkeleton.EventHandler;
using EdaSkeleton.Event;

namespace EdaSkeleton.Service;

public class OrderService
{
    private readonly OrderEventHandler eventHandler;

    public OrderService(OrderEventHandler eventHandler)
    {
        this.eventHandler = eventHandler;
    }

    public void CreateOrder(string product)
    {
        string orderId = Guid.NewGuid().ToString();
        var orderEvent = new OrderCreatedEvent(orderId, product);
        eventHandler.Handle(orderEvent);
    }
}
