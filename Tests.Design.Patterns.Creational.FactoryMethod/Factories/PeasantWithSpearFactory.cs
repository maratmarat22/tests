using Tests.Design.Patterns.Creational.FactoryMethod.Units;

namespace Tests.Design.Patterns.Creational.FactoryMethod.Factories;

public class PeasantWithSpearFactory : IUnitFactory
{
    public Unit CreateInstance() => new PeasantWithSpear("Sir Goodman Goodmanson");
}