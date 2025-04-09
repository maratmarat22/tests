namespace Tests.Design.Patterns.Creational.AbstractFactory.Units.Abstract;

public abstract class PeasantWithSpear(int health, int damage, string lord)
    : Unit(health, damage, lord)
{
    public override string PraiseTheLord() => $"God save our {_lord}";
}