namespace ConsoleApp2;

internal static class Program
{
    private static void Main()
    {
        var prod = new Producer();
        //prod.OnNoArgsEvent += (sender, e) => Console.WriteLine($"Event Raised; Sender = {sender}, EventArgs = {e}");
        //prod.OnStringArgEvent += (sender, e) => Console.WriteLine($"Event Raised; Sender = {sender}, EventArgs = {e}");
        var cons = new Consumer();

        prod.OnNoArgsEvent += cons.Consume;
        prod.OnNoArgsEvent += cons.Consume;
        
        prod.RaiseNoArgsEvent();
        prod.RaiseStringArgEvent();
    }
}