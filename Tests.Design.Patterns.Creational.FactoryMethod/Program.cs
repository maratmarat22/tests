using Tests.Design.Patterns.Creational.FactoryMethod.Factories;
using Tests.Design.Patterns.Creational.FactoryMethod.Units;

namespace Tests.Design.Patterns.Creational.FactoryMethod;
/*
    Данный тест демонстрирует пример использования паттерна Factory method
*/
internal static class Program
{
    private static void Main()
    {
        IUnitFactory knightFactory = new KnightFactory();
        IUnitFactory peasantFactory = new PeasantWithSpearFactory();

        var units = new List<Unit>();

        units.AddRange(Enumerable.Range(0, 3)
            .Select(_ => knightFactory.CreateInstance()));
        units.AddRange(Enumerable.Range(0, 10)
            .Select(_ => peasantFactory.CreateInstance()));
        
        units.ForEach(u =>
        {
            var unitType = u.GetType().Name;
            Console.WriteLine($"{unitType} shouts: {u.PraiseTheLord()}");
        });

        Console.WriteLine();
    }
}