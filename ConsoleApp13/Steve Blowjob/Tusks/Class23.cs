using System;

class Class23
{
    public static void Run()
    {
        int[] array = { 3, 7, 2, 9, 5, 4, 8 };
        int maxIndex = Array.IndexOf(array, array.Max());
        int minIndex = Array.IndexOf(array, array.Min());

        if (Math.Abs(maxIndex - minIndex) <= 1)
        {
            Console.WriteLine("Между максимальным и минимальным элементами нет чисел.");
        }
        else
        {
            int count = Math.Abs(maxIndex - minIndex) - 1;
            Console.WriteLine($"Количество чисел между максимальным и минимальным элементами: {count}");
        }
    }
}