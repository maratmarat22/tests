namespace Tests.Design.Patterns.Structural.Composite;

internal static class Program
{
    private static void Main()
    {
        var vfs = new VirtualFileSystem();
        vfs.CreateDirectory("root/abc");
    }
}