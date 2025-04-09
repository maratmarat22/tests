namespace Tests.Design.Patterns.Disposable;

public class FileHolder() : IDisposable
{
    private readonly StreamWriter _writer = new StreamWriter(new MemoryStream());
    private bool _disposed = false;
    
    
    public void Dispose()
    {
        Console.WriteLine("Disposing FileHolder");
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing)
    {
        if (_disposed) return;
        if (disposing)
        {
            _writer.Dispose();
        }
        // Здесь должны быть освобождены неуправляемые ресурсы
        
        _disposed = true;
    }

    ~FileHolder()
    {
        Dispose(false);
    }
}