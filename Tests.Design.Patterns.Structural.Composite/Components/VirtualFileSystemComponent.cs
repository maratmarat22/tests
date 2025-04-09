namespace Tests.Design.Patterns.Structural.Composite.Components;

public abstract class VirtualFileSystemComponent(string name)
{
    public string Name { get; } = name;

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj)) return true;
        if (obj == null || GetType() != obj.GetType()) return false;
        var other = (VirtualFileSystemComponent)obj;

        return Name == other.Name;
    }
    
    public override int GetHashCode() => Name.GetHashCode();
}