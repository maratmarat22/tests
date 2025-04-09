namespace Tests.Events.EventTest;

public class FileConsumer(Guid guid, string logDirectory) : INotifyEventConsumer
{
    private readonly string _guid = guid.ToString();
    private readonly string _logDirectory = logDirectory; 
    
    public void HandleNotifyEvent(string notification)
    {
        using var writer = new StreamWriter(_logDirectory + @"\" + _guid);
        writer.WriteLine(notification);
    }
}