using System;

class Class9
{
    public static void Run()
    {
        int[] array = { 25, 71, 84, 36, 52, 17, 48 };
        int[] newArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i] / 10;
        }

        Console.WriteLine("Исходный массив: " + string.Join(" ", array));
        Console.WriteLine("Новый массив (старшие разряды): " + string.Join(" ", newArray));
    }
}