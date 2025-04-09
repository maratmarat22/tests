namespace Tests.Collections.Arrays.Declarations;

internal static class Program
{
    private static void Main()
    {
        var numbers1 = new int[5];
        var numbers2 = new int[] { 1, 2, 3, 4, 5 };
        var numbers3 = new[] { 1, 2, 3, 4, 5 };
        int[] numbers4 = [1, 2, 3, 4, 5];
    }
}