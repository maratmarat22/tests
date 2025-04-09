namespace Tests.Collections.Iterating.Foreach.Collections.Custom;

public class CustomCollection<T>(T[] items)
{
    private readonly T[] _items = items;
    
    public CustomEnumerator<T> GetEnumerator() => new CustomEnumerator<T>(_items);
}