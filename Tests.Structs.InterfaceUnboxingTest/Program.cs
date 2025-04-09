namespace Tests.Structs.InterfaceUnboxingTest;
/*
    Данный тест демонстрирует неожиданное поведение при распаковке структур в интерфейсы.
*/
internal static class Program
{
    private static void Main()
    {
        var point = new Point();
        Console.WriteLine($"Original point: {point}");
        
        var boxedPoint = (object)point;
        Console.WriteLine("Boxing point");
        Console.WriteLine($"Boxed point: {boxedPoint}");
        
        // Чтобы при распаковке структуры не получить неожиданные значения, стоит воздержаться
        // от использования подобных интерфейсов в данном контексте.
        var mutablePoint = (IMutablePoint)boxedPoint;
        mutablePoint.Mutate(10, 10);
        Console.WriteLine("Casting boxed point to IMutablePoint and mutating it");
        Console.WriteLine($"Unboxed point as IMutablePoint: {mutablePoint}");
        
        var unboxedPoint = (Point)boxedPoint;
        Console.WriteLine($"Unboxed point as Point: {unboxedPoint}");
    }
}

internal interface IMutablePoint
{
    void Mutate(int x, int y);
}

internal struct Point(int x, int y) : IMutablePoint
{
    private int _x = x;
    private int _y = y;

    public void Mutate(int x, int y)
    {
        _x = x;
        _y = y;
    }
    
    public override string ToString() => $"({_x}, {_y})";
}