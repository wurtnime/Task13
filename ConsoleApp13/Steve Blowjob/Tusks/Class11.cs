using System;
using System.Collections.Generic;
using System.Linq;

class Class11
{
    public static void Run()
    {
        int[] array = { 1, 0, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1 };
        var result = array.Where(x => array.Count(y => y == x) <= 2).ToArray();

        Console.WriteLine("Исходный массив: " + string.Join(" ", array));
        Console.WriteLine("Массив после удаления: " + string.Join(" ", result));
    }
}