using System;

class Class7
{
    public static void Run()
    {
        int[] array = { 25, 71, 84, 36, 52, 17, 48 };
        int[] newArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = SwapDigits(array[i]);
        }

        Console.WriteLine("Исходный массив: " + string.Join(" ", array));
        Console.WriteLine("Новый массив: " + string.Join(" ", newArray));
    }

    private static int SwapDigits(int number)
    {
        int tens = number / 10;
        int units = number % 10;
        return units * 10 + tens;
    }
}