using System;
using System.Linq;

class Class10
{
    public static void Run()
    {
        double[] array1 = { 3.5, 7.2, 1.8, 9.3, 4.6, 2.1, 5.7 };
        double[] array2 = { 6.4, 8.9, 0.5, 2.3, 7.1, 4.8, 3.2, 9.6, 1.4 };
        double[] combinedArray = array1.Concat(array2).OrderByDescending(x => x).ToArray();

        Console.WriteLine("Массив 1: " + string.Join(" ", array1));
        Console.WriteLine("Массив 2: " + string.Join(" ", array2));
        Console.WriteLine("Объединенный и отсортированный массив: " + string.Join(" ", combinedArray));
    }
}