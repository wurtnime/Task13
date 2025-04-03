using System;

class Class24
{
    public static void Run()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int lastElement = array[^1];

        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = lastElement;

        Console.WriteLine("Массив после сдвига: " + string.Join(" ", array));
    }
}