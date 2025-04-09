using Tests.Design.Patterns.Creational.Builder.Builders;

namespace Tests.Design.Patterns.Creational.Builder;

public class CastleDirector(ICastleBuilder builder)
{
    public ICastleBuilder Builder { private get; set; } = builder;
    
    public Castle BuildFullCastle()
    {
        Builder.Castle = new Castle();
        Builder.BuildMotte()
            .BuildKeep()
            .BuildWalls()
            .BuildTowers()
            .BuildMoat()
            .BuildBarbican()
            .BuildForge()
            .BuildStable();
        
        return Builder.Castle;
    }
}