using System;

class Class5
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
        string octalValue = Convert.ToString((int)decimalValue, 8) + "." + ConvertFractionalToOctal(fractionalPart);
        Console.WriteLine($"Восьмеричное представление: {octalValue}");
    }

    private static string ConvertFractionalToOctal(double fractional)
    {
        string result = "";
        for (int i = 0; i < 5; i++) 
        {
            fractional *= 8;
            int digit = (int)fractional;
            result += digit.ToString();
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