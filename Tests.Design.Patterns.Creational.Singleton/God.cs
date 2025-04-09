namespace Tests.Design.Patterns.Creational.Singleton;

public class God
{
    private static God? _instance;
    private static readonly Lock Lock = new();
    
    private God() { }

    public static God Instance
    {
        get
        {
            lock (Lock)
            {
                _instance ??= new God();
                return _instance;
            }
        }
    }

    public void Bless(ref bool blessed) => blessed = true;
}