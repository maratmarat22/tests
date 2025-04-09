namespace ConsoleApp3;

internal static class Program
{
    private static void Main()
    {
        Display("This is test input");
    }
    
    private static void Display<T>(IEnumerable<T> values)
    {
        using (var enumerator = values.GetEnumerator())
        {
            var i = 0;

            while (enumerator.MoveNext() && i < 9)
            {
                System.Console.Write(enumerator.Current);
                ++i;
            }
        }
    }

}