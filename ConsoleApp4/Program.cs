namespace ConsoleApp4;

internal static class Program
{
    private static void Main()
    {
        var i = 0;
        var threads = new List<Thread>();
        while (true)
        {
            Console.WriteLine(i);
            threads.Add(new Thread(InfiniteLoop));
            threads[i].Start();
            ++i;
        }
    }

    private static void InfiniteLoop()
    {
        while (true) { }
    }
}