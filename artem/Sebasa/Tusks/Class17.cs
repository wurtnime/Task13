using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task17
    {
        public string Execute(string binaryInput)
        {
            if (IsBinary(binaryInput))
            {
                string shiftedBinary = binaryInput[^1..] + binaryInput[..^1];
                int originalDecimal = Convert.ToInt32(binaryInput, 2);
                int shiftedDecimal = Convert.ToInt32(shiftedBinary, 2);

                return $"После сдвига: {shiftedBinary} (десятичное: {shiftedDecimal}), Сумма: {originalDecimal + shiftedDecimal}";
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