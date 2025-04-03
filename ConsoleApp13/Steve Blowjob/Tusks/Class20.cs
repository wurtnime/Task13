using System;

class Class20
{
    public static void Run()
    {
        int[] array = { 2, 4, 8, 16, 32 };
        if (array.Length < 2)
        {
            Console.WriteLine("Массив слишком мал для проверки.");
            return;
        }

        double ratio = (double)array[1] / array[0];
        bool isGeometric = true;

        for (int i = 1; i < array.Length; i++)
        {
            if ((double)array[i] / array[i - 1] != ratio)
            {
                isGeometric = false;
                break;
            }
        }

        if (isGeometric)
        {
            Console.WriteLine($"Массив образует геометрическую прогрессию со знаменателем {ratio}");
        }
        else
        {
            Console.WriteLine("Массив не образует геометрическую прогрессию.");
        }
    }
}