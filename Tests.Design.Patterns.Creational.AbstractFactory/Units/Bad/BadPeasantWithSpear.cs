using Tests.Design.Patterns.Creational.AbstractFactory.Units.Abstract;

namespace Tests.Design.Patterns.Creational.AbstractFactory.Units.Bad;

public class BadPeasantWithSpear(int health, int damage, string lord)
    : PeasantWithSpear(health, damage, lord)
{
    
}