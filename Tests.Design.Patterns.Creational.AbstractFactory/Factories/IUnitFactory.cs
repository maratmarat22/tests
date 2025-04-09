using Tests.Design.Patterns.Creational.AbstractFactory.Units.Abstract;

namespace Tests.Design.Patterns.Creational.AbstractFactory.Factories;

public interface IUnitFactory
{
    Unit CreateKnight();
    Unit CreatePeasantWithSpear();
}