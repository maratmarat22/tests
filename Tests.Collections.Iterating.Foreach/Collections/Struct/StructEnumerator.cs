using System.Collections;

namespace Tests.Collections.Iterating.Foreach.Collections.Struct;

public struct StructEnumerator<T>(T[] items) : IEnumerator<T>
{
    private readonly T[] _items = items;
    private int _index = -1;
    public T Current => _items[_index];
    public bool MoveNext() => ++_index < _items.Length;
    public void Reset() => _index = -1;
    object? IEnumerator.Current => Current;
    public void Dispose() { }
}