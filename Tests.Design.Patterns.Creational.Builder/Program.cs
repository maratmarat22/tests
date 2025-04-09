using Tests.Design.Patterns.Creational.Builder.Builders;

namespace Tests.Design.Patterns.Creational.Builder;
/*
    Данный класс демонстрирует использование паттерна Builder (обычный вариант).
*/
internal static class Program
{
    private static void Main()
    {
        ICastleBuilder builder = new CastleBuilder();
        builder.BuildKeep()
            .BuildMotte()
            .BuildWalls()
            .BuildBarbican();
        var castle = builder.Castle;
        Console.WriteLine(castle.ToString());
        
        ICastleBuilder builder2 = new CastleBuilder();
        builder2.Castle = castle;
        builder2.BuildStable();
        castle = builder2.Castle;
        Console.WriteLine(castle.ToString());
        
        var director = new CastleDirector(new CastleBuilder());
        var castle2 = director.BuildFullCastle();
        Console.WriteLine(castle2.ToString());
    }
}