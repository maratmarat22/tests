namespace Tests.Events.EventTest;
/*
    Данный тест демонстрирует использование событий в C# 
*/
internal static class Program
{
    private static void Main()
    {
        var logDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Logs"));
        if (!Directory.Exists(logDirectory))
        {
            throw new DirectoryNotFoundException(logDirectory);
        }
        var notifier = new Notifier();
        var listeners = new List<INotifyEventConsumer>();
        for (var i = 0; i < 10; ++i)
        {
            if (i % 2 == 0)
            {
                listeners.Add(new ConsoleConsumer());
            }
            else
            {
                listeners.Add(new FileConsumer(Guid.NewGuid(), logDirectory));
            }
        }
        
        foreach (var listener in listeners)
        {
            notifier.NotifyEvent += listener.HandleNotifyEvent;
        }
        
        notifier.Publish("message 1");
    }
}