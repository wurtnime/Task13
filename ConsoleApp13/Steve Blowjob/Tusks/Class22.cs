using System;

class Class22
{
    public static void Run()
    {
        int[] array = { 1, 3, 2, 4, 3, 5, 4, 6 };
        int lastIndex = -1;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i - 1] < array[i] && array[i] < array[i + 1])
            {
                lastIndex = i;
            }
        }

        if (lastIndex != -1)
        {
            Console.WriteLine($"Номер последнего элемента, удовлетворяющего условию: {lastIndex}");
        }
        else
        {
            Console.WriteLine("Таких элементов нет.");
        }
    }
}