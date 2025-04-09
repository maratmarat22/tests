namespace Tests.Design.Patterns.Disposable;
/*
    Данный тест демонстрирует использование паттерна Disposable с управляемыми ресурсами.
*/
internal static class Program
{
    private static void Main()
    {
        using (var holder = new FileHolder())
        {
            
        }
        
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("Press any key to exit...");
    }
}