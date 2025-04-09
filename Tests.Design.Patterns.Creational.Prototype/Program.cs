namespace Tests.Design.Patterns.Creational.Prototype;
/*
    Данный тест демонстрирует использование паттерна Prototype.
*/
internal static class Program
{
    private static void Main()
    {
        var knight = new Knight("Sir Foo Barson");
        var horse = new Horse("Baz");
        Console.WriteLine(knight);
        knight.Mount = horse;
        Console.WriteLine(knight);

        var clone = (Knight)knight.Clone();
        
        Console.WriteLine("knight ref-equals to clone: " + knight.Equals(clone));
        Console.WriteLine("knight's mount ref-equals to clone's mount: " + knight.Mount.Equals(clone.Mount));
    }
}