namespace Tests.Events.EventTest;

public class ConsoleConsumer : INotifyEventConsumer
{
    public void HandleNotifyEvent(string notification)
    {
        Console.WriteLine(notification);
    }
}