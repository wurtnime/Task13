using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task2
    {
        public string Execute(string binaryInput)
        {
            if (IsBinary(binaryInput))
            {
                int decimalValue = Convert.ToInt32(binaryInput, 2);
                string octalValue = Convert.ToString(decimalValue, 8);
                return $"Восьмеричное представление: {octalValue}";
            }
            return "Ошибка: введено некорректное двоичное число.";
        }

        private bool IsBinary(string input)
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
}