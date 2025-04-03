using System;

class Class26
{
    public static void Run()
    {
        int[] array = { 5, 10, 15, 20 };
        int binaryNumber = Convert.ToInt32("1010", 2); 

        for (int i = 0; i < array.Length; i++)
        {
            array[i] += binaryNumber;
        }

        Console.WriteLine("Массив после увеличения: " + string.Join(" ", array));
    }
}