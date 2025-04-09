namespace ConsoleApp2;

public class Consumer
{
    public void Consume(object? sender, EventArgs e)
        => Console.WriteLine($"Event Raised; Sender = {sender}, EventArgs = {e}");
}