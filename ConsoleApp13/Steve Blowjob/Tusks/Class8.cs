using System;

class Class8
{
    public static void Run()
    {
        string[] octalArray = { "12", "34", "56", "71", "23", "45", "67", "70", "11" };
        int[] decimalArray = new int[octalArray.Length];

        for (int i = 0; i < octalArray.Length; i++)
        {
            decimalArray[i] = Convert.ToInt32(octalArray[i], 8);
        }

        Console.WriteLine("Исходный массив (восьмеричный): " + string.Join(" ", octalArray));
        Console.WriteLine("Новый массив (десятичный): " + string.Join(" ", decimalArray));
    }
}