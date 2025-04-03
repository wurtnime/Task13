using System;

class Class16
{
    public static void Run()
    {
        string[] binaryArray = { "101", "110", "1001", "11", "1010" };
        int[] decimalArray = binaryArray.Select(x => Convert.ToInt32(x, 2)).ToArray();

        int maxIndex = Array.IndexOf(decimalArray, decimalArray.Max());
        int minIndex = Array.IndexOf(decimalArray, decimalArray.Min());

        string temp = binaryArray[maxIndex];
        binaryArray[maxIndex] = binaryArray[minIndex];
        binaryArray[minIndex] = temp;

        Console.WriteLine("Исходный массив: " + string.Join(" ", binaryArray));
        Console.WriteLine("Массив после замены: " + string.Join(" ", binaryArray));
    }
}