using System.Collections;

namespace Tests.Collections.Iterating.Foreach.Collections.Struct;

public readonly struct StructCollection<T>(T[] items) : IEnumerable<T>
{
    private readonly T[] _items = items;
    
    public IEnumerator<T> GetEnumerator() => new StructEnumerator<T>(_items);
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public T this[int index]
    {
        get => _items[index];
        set => _items[index] = value;
    }
}