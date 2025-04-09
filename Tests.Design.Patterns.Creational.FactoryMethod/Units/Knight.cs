namespace Tests.Design.Patterns.Creational.FactoryMethod.Units;

public class Knight(string lord) : Unit(lord)
{
    public override string PraiseTheLord() => $"Glory to {Lord}!";
}