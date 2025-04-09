namespace Tests.Design.Patterns.Creational.Singleton;

public class Unit
{
    private bool _blessed;
    public ref bool Blessed
    {
        get => ref _blessed;
    }

    public void AskForBlessing()
    {
        var GodInstance = God.Instance;
        GodInstance.Bless(ref Blessed);
    }

    public override string ToString()
    {
        return Blessed ? "I'm blessed" : "I'm not blessed";
    }
}