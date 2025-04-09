namespace Tests.Design.Patterns.Creational.Prototype;

public class Knight (string name) : ICloneable
{
    public string Name { get; } = name;

    public Horse? Mount { get; set; }

    public object Clone()
    {
        var clone = new Knight(Name);
        if (Mount != null)
        {
            clone.Mount = new Horse(Mount.Name);
        }
        
        return clone;
    }

    public override string ToString()
    {
        return Mount == null
            ? $"My name is {Name} and I don't have any horse."
            : $"My name is {Name} and here is my horse {Mount.Name}.";

    }
}