using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task4
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
                return $"Десятичное представление: {decimalValue}";
            }
            return "Ошибка: введено некорректное дробное двоичное число.";
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
