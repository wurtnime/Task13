using System;

class Class2
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
        string octalValue = Convert.ToString(decimalValue, 8);
        Console.WriteLine($"Восьмеричное представление: {octalValue}");
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