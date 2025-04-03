using System;
using System.Collections.Generic;

class Class21
{
    public static void Run()
    {
        int[] array = { 3, 7, 2, 9, 5, 4, 8 };
        List<int> indices = new List<int>();

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                indices.Add(i);
            }
        }

        Console.WriteLine("Индексы элементов, больших, чем справа: " + string.Join(" ", indices));
        Console.WriteLine($"Количество таких элементов: {indices.Count}");
    }
}