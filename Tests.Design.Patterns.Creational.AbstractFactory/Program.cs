using Tests.Design.Patterns.Creational.AbstractFactory.Factories;
using Tests.Design.Patterns.Creational.AbstractFactory.Units.Abstract;

namespace Tests.Design.Patterns.Creational.AbstractFactory;
/*
    Данный тест демонстрирует пример использования паттерна Abstract factory
*/
internal static class Program
{
    private static void Main()
    {
        IUnitFactory badUnitFactory = new BadUnitFactory("Sir Bastard Bastardson");
        IUnitFactory goodUnitFactory = new GoodUnitFactory("Sir Goodman Goodmanson");

        var units = new List<Unit>();
        
        for (var i = 0; i < 3; ++i)
        {
            units.Add(badUnitFactory.CreateKnight());
            units.Add(goodUnitFactory.CreateKnight());
        }

        for (var i = 0; i < 10; ++i)
        {
            units.Add(badUnitFactory.CreatePeasantWithSpear());
            units.Add(goodUnitFactory.CreatePeasantWithSpear());
        }

        units.ForEach
            (u => Console.WriteLine($"{u.GetType().Name} shouts: {u.PraiseTheLord()}"));
        
        var a = units.Where(u => u.Health > 10)
            .GroupBy(u => u.Health)
            .Select(g => g.First());
    }
}