using System;
using System.Linq;

class Class14
{
    public static void Run()
    {
        string[] binaryArray = { "101", "110", "1001", "11", "1010" };
        var sortedArray = binaryArray.OrderByDescending(x => Convert.ToInt32(x, 2)).ToArray();
        int sum = sortedArray.Sum(x => Convert.ToInt32(x, 2));

        Console.WriteLine("Исходный массив: " + string.Join(" ", binaryArray));
        Console.WriteLine("Отсортированный массив: " + string.Join(" ", sortedArray));
        Console.WriteLine($"Сумма чисел: {sum}");
    }
}