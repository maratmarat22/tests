namespace Tests.Design.Patterns.Creational.FactoryMethod.Units;

public class PeasantWithSpear(string lord) : Unit(lord)
{
    public override string PraiseTheLord() => $"God save our {Lord}!";
}