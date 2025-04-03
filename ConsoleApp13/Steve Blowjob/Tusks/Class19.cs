using System;

class Class19
{
    public static void Run()
    {
        int[] array = { 1, 3, 5, 7, 9 };
        int difference = array[1] - array[0];
        bool isArithmetic = true;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] - array[i - 1] != difference)
            {
                isArithmetic = false;
                break;
            }
        }

        if (isArithmetic)
        {
            Console.WriteLine($"Массив образует арифметическую прогрессию с разностью {difference}");
        }
        else
        {
            Console.WriteLine("Массив не образует арифметическую прогрессию.");
        }
    }
}