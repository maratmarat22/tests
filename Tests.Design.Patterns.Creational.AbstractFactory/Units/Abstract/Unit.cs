namespace Tests.Design.Patterns.Creational.AbstractFactory.Units.Abstract;

public abstract class Unit(int health, int damage, string lord)
{
    public int Health { get; set; } = health;
    public int Damage { get; set; } = damage;
    protected readonly string _lord  = lord;

    public abstract string PraiseTheLord();
}