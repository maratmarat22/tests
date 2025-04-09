using System.Collections;

namespace Tests.Collections.Iterating.Foreach.Collections.Type;

public class TypeCollection<T>(T[] collection) : IEnumerable<T>
{
    public IEnumerator<T> GetEnumerator() => new TypeEnumerator<T>(collection);
    
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}