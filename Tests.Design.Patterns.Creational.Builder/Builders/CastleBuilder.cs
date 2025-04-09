namespace Tests.Design.Patterns.Creational.Builder.Builders;

public class CastleBuilder : ICastleBuilder
{
    public Castle Castle { get; set; } = new Castle();
    
    public ICastleBuilder BuildMotte()
    {
        Castle.Motte = true;
        return this;
    }

    public ICastleBuilder BuildKeep()
    {
        Castle.Keep = true;
        return this;
    }

    public ICastleBuilder BuildWalls()
    {
        Castle.Walls = true;
        return this;
    }

    public ICastleBuilder BuildTowers()
    {
        Castle.Towers = true;
        return this;
    }

    public ICastleBuilder BuildMoat()
    {
        Castle.Moat = true;
        return this;
    }

    public ICastleBuilder BuildBarbican()
    {
        Castle.Barbican = true;
        return this;
    }

    public ICastleBuilder BuildStable()
    {
        Castle.Stable = true;
        return this;
    }

    public ICastleBuilder BuildForge()
    {
        Castle.Forge = true;
        return this;
    }
}