namespace Tests.Events.EventTest;

internal class Notifier
{
    internal delegate void NotifyEventHandler(string notification);
    
    internal event NotifyEventHandler? NotifyEvent;

    public void Publish(string notification)
    {
        NotifyEvent?.Invoke(notification);
    }
}