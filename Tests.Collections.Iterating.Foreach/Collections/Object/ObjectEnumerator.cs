using System.Collections;

namespace Tests.Collections.Iterating.Foreach.Collections.Object;

public class ObjectEnumerator : IEnumerator
{
    private readonly object[] _items = [1, 2, 3, 4, "hello", new object()];
    private int _index = -1;

    public object Current => _items[_index];
    
    public bool MoveNext()
    {
        ++_index;
        return _index < _items.Length;
    }

    public void Reset()
    {
        _index = -1;
    }
}