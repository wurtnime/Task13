using System;

class Class13
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

        string shiftedBinary = binaryInput.Substring(2) + binaryInput.Substring(0, 2);
        int originalDecimal = Convert.ToInt32(binaryInput, 2);
        int shiftedDecimal = Convert.ToInt32(shiftedBinary, 2);

        Console.WriteLine($"Исходное число: {binaryInput} (десятичное: {originalDecimal})");
        Console.WriteLine($"После сдвига: {shiftedBinary} (десятичное: {shiftedDecimal})");
        Console.WriteLine($"Разность: {originalDecimal - shiftedDecimal}");
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