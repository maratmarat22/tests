using Tests.Design.Patterns.Creational.FactoryMethod.Units;

namespace Tests.Design.Patterns.Creational.FactoryMethod.Factories;

public class KnightFactory : IUnitFactory
{
    public Unit CreateInstance() => new Knight("Sir Goodman Goodmanson");
}