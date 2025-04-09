namespace Tests.Events.EventTest;

public interface INotifyEventConsumer
{
    public void HandleNotifyEvent(string notification);
}