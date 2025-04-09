namespace Tests.Design.Patterns.Creational.FactoryMethod.Units;

public abstract class Unit(string lord)
{
    protected readonly string Lord = lord;

    public abstract string PraiseTheLord();
}