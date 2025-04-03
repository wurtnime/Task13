using System;

class Class1
{
    public static void Run()
    {
        Console.WriteLine("Введите двоичное число:");
        string binaryInput = Console.ReadLine();

        if (!IsBinary(binaryInput))
        {
            Console.WriteLine("Ошибка: введено некорректное двоичное число.");
            return;
        }

        int decimalValue = Convert.ToInt32(binaryInput, 2);
        Console.WriteLine($"Десятичное представление: {decimalValue}");
    }

    private static bool IsBinary(string input)
    {
        foreach (char c in input)
        {
            if (c != '0' && c != '1')
            {
                return false;
            }
        }
        return true;
    }
}