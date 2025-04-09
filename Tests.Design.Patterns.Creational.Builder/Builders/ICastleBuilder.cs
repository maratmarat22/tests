namespace Tests.Design.Patterns.Creational.Builder.Builders;

public interface ICastleBuilder
{
    Castle Castle { get; set; }
    
    ICastleBuilder BuildMotte();
    ICastleBuilder BuildKeep();
    ICastleBuilder BuildWalls();
    ICastleBuilder BuildTowers();
    ICastleBuilder BuildMoat();
    ICastleBuilder BuildBarbican();
    ICastleBuilder BuildForge();
    ICastleBuilder BuildStable();
}