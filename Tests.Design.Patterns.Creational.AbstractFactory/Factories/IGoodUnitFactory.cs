using Tests.Design.Patterns.Creational.AbstractFactory.Units.Abstract;
using Tests.Design.Patterns.Creational.AbstractFactory.Units.Good;

namespace Tests.Design.Patterns.Creational.AbstractFactory.Factories;

public class GoodUnitFactory(string lord) : IUnitFactory
{
    private readonly string _lord = lord; 
    public Unit CreateKnight() => new GoodKnight(500, 10, _lord);
    public Unit CreatePeasantWithSpear() => new GoodPeasantWithSpear(100, 1, _lord);
}