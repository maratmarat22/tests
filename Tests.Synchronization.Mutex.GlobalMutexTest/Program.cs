namespace Tests.Synchronization.Mutex.GlobalMutexTest;
/*
    Данный тест демонстрирует использование мьютекса для ограничения доступа
    к критической секции среди разных процессов.
    Запустите несколько инстанций проекта.
*/
internal static class Program
{
    private static void Main()
    {
        var processId = Environment.ProcessId.ToString();
        
        Console.WriteLine($"Process {processId} started");
        
        var globalMutex = new System.Threading.Mutex(false, "GlobalMutexTest");
        globalMutex.WaitOne();
        Console.WriteLine($"Process {processId} entered critical section");
        Thread.Sleep(TimeSpan.FromSeconds(10));
        globalMutex.ReleaseMutex();

        Console.WriteLine($"Process {processId} left critical section");
    }
}