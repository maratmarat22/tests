namespace ConsoleApp1;

internal static class Program
{
    private static void Main()
    {
        var str1 = "str";
        var str2 = "str";

        Console.WriteLine(str1 == str2);
        Console.WriteLine(str1.Equals(str2));
        Console.WriteLine(ReferenceEquals(str1, str2));
        Console.WriteLine();
        
        var obj1 = new object();
        var obj2 = new object();
        
        Console.WriteLine(obj1 == obj2);
        Console.WriteLine(obj1.Equals(obj2));
        Console.WriteLine(ReferenceEquals(obj1, obj2));
        Console.WriteLine();
        
        var objectWithRedefinedEquals1 = new ObjectWithRedefinedEquals(1);
        var objectWithRedefinedEquals2 = new ObjectWithRedefinedEquals(1);

        Console.WriteLine(objectWithRedefinedEquals1 == objectWithRedefinedEquals2);
        Console.WriteLine(objectWithRedefinedEquals1.Equals(objectWithRedefinedEquals2));
        Console.WriteLine(ReferenceEquals(objectWithRedefinedEquals1, objectWithRedefinedEquals2));
    }
}

internal class ObjectWithRedefinedEquals(int id)
{
    private readonly int _id = id;

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj)) return true;
        if (obj == null || GetType() != obj.GetType()) return false;
        var other = (ObjectWithRedefinedEquals)obj;

        return _id == other._id;
    }

    public override int GetHashCode() => _id;

    public static bool operator ==(ObjectWithRedefinedEquals obj1, ObjectWithRedefinedEquals obj2)
        => obj1.Equals(obj2);
    
    public static bool operator !=(ObjectWithRedefinedEquals obj1, ObjectWithRedefinedEquals obj2)
        => !(obj1 == obj2);
}