using System;

class Class30
{
    public static void Run()
    {
        int[] decimalArray = { 5, 10, 15, 20 };
        string[] binaryArray = new string[decimalArray.Length];

        for (int i = 0; i < decimalArray.Length; i++)
        {
            binaryArray[i] = Convert.ToString(decimalArray[i], 2);
        }

        Console.WriteLine("Исходный массив (десятичный): " + string.Join(" ", decimalArray));
        Console.WriteLine("Массив в двоичной системе: " + string.Join(" ", binaryArray));
    }
}