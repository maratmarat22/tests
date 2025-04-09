namespace Tests.Design.Patterns.Structural.Composite.Components;

public class VirtualDirectory(string name) : VirtualFileSystemComponent(name)
{
    public List<VirtualFileSystemComponent> Components { get; set; } = [];

    public string[] Open() => Components.Select(f => f.Name).ToArray();
}