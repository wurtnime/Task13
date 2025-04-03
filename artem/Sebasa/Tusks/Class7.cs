using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task7
    {
        public string Execute(int[] array)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = SwapDigits(array[i]);
            }

            return $"Новый массив: {string.Join(" ", newArray)}";
        }

        private int SwapDigits(int number)
        {
            int tens = number / 10;
            int units = number % 10;
            return units * 10 + tens;
        }
    }
}