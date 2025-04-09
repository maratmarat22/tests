namespace Tests.Design.Patterns.Creational.AbstractFactory.Units.Abstract;

public abstract class Knight(int health, int damage, string lord)
    : Unit(health, damage, lord)
{
    public override string PraiseTheLord() => $"Glory to {_lord}!";
}