using System;
using System.Linq;

class Class15
{
    public static void Run()
    {
        string[] binaryArray = { "101", "110", "1001", "11", "1010" };
        var sortedArray = binaryArray.OrderBy(x => Convert.ToInt32(x, 2)).ToArray();
        double average = sortedArray.Average(x => Convert.ToInt32(x, 2));

        Console.WriteLine("Исходный массив: " + string.Join(" ", binaryArray));
        Console.WriteLine("Отсортированный массив: " + string.Join(" ", sortedArray));
        Console.WriteLine($"Среднее значение: {average}");
    }
}