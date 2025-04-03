using System;

class Class6
{
    public static void Run()
    {
        Console.WriteLine("Введите дробное двоичное число (например, 101.101):");
        string binaryInput = Console.ReadLine();

        if (!IsBinaryFraction(binaryInput))
        {
            Console.WriteLine("Ошибка: введено некорректное дробное двоичное число.");
            return;
        }

        string[] parts = binaryInput.Split('.');
        int integerPart = Convert.ToInt32(parts[0], 2);
        double fractionalPart = 0;

        for (int i = 0; i < parts[1].Length; i++)
        {
            if (parts[1][i] == '1')
            {
                fractionalPart += Math.Pow(2, -(i + 1));
            }
        }

        double decimalValue = integerPart + fractionalPart;
        string hexValue = Convert.ToString((int)decimalValue, 16).ToUpper() + "." + ConvertFractionalToHex(fractionalPart);
        Console.WriteLine($"Шестнадцатеричное представление: {hexValue}");
    }

    private static string ConvertFractionalToHex(double fractional)
    {
        string result = "";
        for (int i = 0; i < 5; i++) 
        {
            fractional *= 16;
            int digit = (int)fractional;
            result += digit.ToString("X");
            fractional -= digit;
        }
        return result;
    }

    private static bool IsBinaryFraction(string input)
    {
        foreach (char c in input)
        {
            if (c != '0' && c != '1' && c != '.')
            {
                return false;
            }
        }
        return true;
    }
}