using System;

class Class25
{
    public static void Run()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int firstElement = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[^1] = firstElement;

        int sumBefore = array.Sum();
        int sumAfter = array.Sum();

        Console.WriteLine("Массив после сдвига: " + string.Join(" ", array));
        Console.WriteLine($"Сумма до сдвига: {sumBefore}, сумма после сдвига: {sumAfter}");
    }
}