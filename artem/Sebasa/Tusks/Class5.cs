using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task5
    {
        public string Execute(string binaryInput)
        {
            if (IsBinaryFraction(binaryInput))
            {
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
                return $"Восьмеричное представление: {octalValue}";
            }
            return "Ошибка: введено некорректное дробное двоичное число.";
        }

        private string ConvertFractionalToOctal(double fractional)
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

        private bool IsBinaryFraction(string input)
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
}