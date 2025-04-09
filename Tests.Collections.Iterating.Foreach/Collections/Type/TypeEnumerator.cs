using System.Collections;

namespace Tests.Collections.Iterating.Foreach.Collections.Type;

public class TypeEnumerator<T>(T[] items) : IEnumerator<T>
{
    private readonly T[] _items = items;
    private int _index = -1;
    public T Current => _items[_index];
    
    public bool MoveNext() => ++_index < _items.Length;
    public void Reset() => _index = -1;

    public void Dispose() => GC.SuppressFinalize(this);
    
    object? IEnumerator.Current => Current;
}