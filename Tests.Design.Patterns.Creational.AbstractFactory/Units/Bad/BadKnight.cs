using Tests.Design.Patterns.Creational.AbstractFactory.Units.Abstract;

namespace Tests.Design.Patterns.Creational.AbstractFactory.Units.Bad;

public class BadKnight(int health, int damage, string lord)
    : Knight(health, damage, lord)
{
    
}