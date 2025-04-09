namespace Tests.Structs.ReadonlyCopyTest;
/*
    Данный тест демонстрирует, что использование readonly структур при вызове любого их метода
    создает на стеке новую инстанцию структуры и применяет метод на ней, в то время как с оригинальной
    структурой ничего не происходит.
*/
internal static class Program
{
    private static void Main()
    {
        var pets = new Pets();
        pets.FeedCat();
        Console.WriteLine(pets.GetCatWeight());
    }
}

internal class Pets
{
    // Уберите модификатор readonly и программа покормит именно этого кота, а не создаст нового.
    private readonly Cat _cat = new Cat();

    // Rider предупреждает о копировании readonly структур при вызове их методов.
    internal void FeedCat() => _cat.Feed();

    internal int GetCatWeight() => _cat.Weight;
}

internal struct Cat
{
    public int Weight { get; private set; }

    internal void Feed() => ++Weight;
}