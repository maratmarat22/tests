using System.Numerics;

namespace Tests.Delegates.DelegateDeclarationTest;
/*
    Данный тест демонстрирует возможные объявления делегатов и замыкания.
*/
internal static class Program
{
    private static void Main()
    {
        // Объявление с помощью статического метода:
        Sum<int> sumIntegers = SumIntegers;
        Console.WriteLine(sumIntegers(100, 100, 20, 30));

        // Объявление с помощью нестатического метода:
        var doubleCalculator = new DoubleCalculator();
        Sum<double> sumDoubles = doubleCalculator.Sum;
        
        // Делаем заметным замкнутый параметр:
        doubleCalculator.EnclosedParam = 1000;
        Console.WriteLine(sumDoubles(100.5, 100.5, 20.222, 30.9));
        
        // Объявление с помощью анонимной лямбда-функции (можно расписать полноценное тело, если необходимо):
        Sum<float> sumFloat = (params float[] numbers) => numbers.Sum();
        Console.WriteLine(sumFloat(100.5f, 100.5f, 20.222f, 30.9f));
        
        // Объявление с помощью LINQ (по сути тот же анонимный метод):
        sumIntegers = numbers => numbers.Aggregate((x, y) => x + y);
    }

    private static int SumIntegers(params int[] numbers) => numbers.Sum();
}
// Объявляем сигнатуру операции:
internal delegate T Sum<T>(params T[] numbers) where T : INumber<T>;

internal class DoubleCalculator
{
    // Переменная, которая будет замкнута в делегате (в синтетическом классе, сгенерированном CLR):
    public int EnclosedParam { get; set; }
    internal double Sum(params double[] numbers) => numbers.Sum() + EnclosedParam;
}