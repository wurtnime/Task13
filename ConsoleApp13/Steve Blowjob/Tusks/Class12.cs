using System;

class Class12
{
    public static void Run()
    {
        int[] array = { 3, 7, 2, 9, 5, 7, 4 };
        int firstIndex = -1, secondIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    firstIndex = i;
                    secondIndex = j;
                    break;
                }
            }
            if (firstIndex != -1) break;
        }

        if (firstIndex != -1)
        {
            Console.WriteLine($"Одинаковые элементы найдены на позициях: {firstIndex} и {secondIndex}");
        }
        else
        {
            Console.WriteLine("Одинаковые элементы не найдены.");
        }
    }
}