namespace ConsoleApp7;

internal static class Program
{
    private static void Main()
    {
        var task = GetTask();
        task.Wait();
    }

    private static async Task GetTask()
    {
        await Task.Delay(TimeSpan.FromSeconds(10));
    }
}