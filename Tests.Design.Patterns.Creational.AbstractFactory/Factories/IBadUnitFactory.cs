using Tests.Design.Patterns.Creational.AbstractFactory.Units.Abstract;
using Tests.Design.Patterns.Creational.AbstractFactory.Units.Bad;

namespace Tests.Design.Patterns.Creational.AbstractFactory.Factories;

public class BadUnitFactory(string lord) : IUnitFactory
{
    private readonly string _lord = lord;
    public Unit CreateKnight() => new BadKnight(500, 10, _lord);
    public Unit CreatePeasantWithSpear() => new BadPeasantWithSpear(100, 1, _lord);
}