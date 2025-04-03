using System;

class Class17
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

        string shiftedBinary = binaryInput[^1..] + binaryInput[..^1];
        int originalDecimal = Convert.ToInt32(binaryInput, 2);
        int shiftedDecimal = Convert.ToInt32(shiftedBinary, 2);

        Console.WriteLine($"Исходное число: {binaryInput} (десятичное: {originalDecimal})");
        Console.WriteLine($"После сдвига: {shiftedBinary} (десятичное: {shiftedDecimal})");
        Console.WriteLine($"Сумма: {originalDecimal + shiftedDecimal}");
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