namespace Tests.Collections.Iterating.Foreach.Collections.Custom;

public class CustomEnumerator<T>(T[] items)
{
    private readonly T[] _items = items;
    private int _index = -1;
    public bool MoveNext() => ++_index < _items.Length;
    public T Current => _items[_index];
}