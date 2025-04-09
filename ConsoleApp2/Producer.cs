namespace ConsoleApp2;

public class Producer
{
    public event EventHandler? OnNoArgsEvent;
    public event EventHandler<string>? OnStringArgEvent;
    
    public void RaiseNoArgsEvent()
    {
        OnNoArgsEvent?.Invoke(this, EventArgs.Empty);
    }

    public void RaiseStringArgEvent()
    {
        OnStringArgEvent?.Invoke(this, "test");
    }
}