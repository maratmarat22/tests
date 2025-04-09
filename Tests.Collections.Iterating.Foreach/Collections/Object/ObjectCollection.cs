using System.Collections;

namespace Tests.Collections.Iterating.Foreach.Collections.Object;

public class ObjectCollection : IEnumerable
{
    public IEnumerator GetEnumerator() => new ObjectEnumerator();
}