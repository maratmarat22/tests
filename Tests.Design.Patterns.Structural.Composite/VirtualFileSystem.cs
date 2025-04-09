using Tests.Design.Patterns.Structural.Composite.Components;

namespace Tests.Design.Patterns.Structural.Composite;

public class VirtualFileSystem
{
    public List<VirtualFileSystemComponent> Components = [];
    
    public VirtualFileSystem()
    {
        CreateDirectory("root");
    }
    
    public void CreateFile(string name)
    {
        if (Components.FirstOrDefault(c => c.Name == name) != null)
        {
            throw new Exception($"{name} already exists");
        }

        var directories = name.Split(@"\");
        foreach (var directory in directories)
        {
            if (Components)
        }


        Components.Add(new VirtualFile("root/" + name));
    }
    
    public void CreateDirectory(string name)
    {
        var path = name.Split();
        Components.Add(new VirtualDirectory(name));
    }

    private void FindPath(string path)
    {
        
        foreach (var directory in COLLECTION)
        {
            
        }
    }
}