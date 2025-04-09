namespace Tests.Design.Patterns.Creational.Singleton;

internal static class Program
{
    private static void Main()
    {
        var unit = new Unit();
        Console.WriteLine(unit);
        unit.AskForBlessing();
        Console.WriteLine(unit);
    }
}