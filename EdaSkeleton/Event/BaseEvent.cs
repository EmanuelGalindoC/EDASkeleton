namespace EdaSkeleton.Event;

public abstract class BaseEvent
{
    public DateTime Timestamp { get; } = DateTime.UtcNow;
}