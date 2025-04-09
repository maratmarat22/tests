using Tests.Collections.Iterating.Foreach.Collections.Custom;
using Tests.Collections.Iterating.Foreach.Collections.Object;
using Tests.Collections.Iterating.Foreach.Collections.Struct;
using Tests.Collections.Iterating.Foreach.Collections.Type;

namespace Tests.Collections.Iterating.Foreach;
/*
    Данный тест демонстрирует использование конструкции foreach
    на встроенных и определенных пользователем перебираемых сущностях.
*/
internal static class Program
{
    private static void Main()
    {
        var objectCollection = new ObjectCollection();
        foreach (var item in objectCollection)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        var typeCollection = new TypeCollection<int>([1, 2, 3, 4, 5]);
        foreach (var item in typeCollection)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        var structCollection = new StructCollection<double>([1.3, 1.5, 3.5, double.Pi]);
        foreach (var item in structCollection)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(structCollection[2]);
        Console.WriteLine();
        
        var customCollection = new CustomCollection<float>([1.3f, 1.2f, 3.0f, float.E]);
        foreach (var item in customCollection)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        IEnumerable<double> enumerable = structCollection;
        var res = enumerable.Select(n => n * 2);
        foreach (var item in res)
        {
            Console.WriteLine(item);
        }
    }
}