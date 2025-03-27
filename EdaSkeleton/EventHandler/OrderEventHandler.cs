using EdaSkeleton.Event;

namespace EdaSkeleton.EventHandler;

public class OrderEventHandler
{
    public void Handle(OrderCreatedEvent orderEvent)
    {
        Console.WriteLine($"[Event Received] Order created - ID: {orderEvent.OrderId}, Product: {orderEvent.Product}");
    }
}
