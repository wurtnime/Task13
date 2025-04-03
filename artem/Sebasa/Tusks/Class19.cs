using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task19
    {
        public string Execute(int[] array)
        {
            if (array.Length < 2)
            {
                return "Массив слишком мал для проверки.";
            }

            int difference = array[1] - array[0];
            bool isArithmetic = true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] - array[i - 1] != difference)
                {
                    isArithmetic = false;
                    break;
                }
            }

            if (isArithmetic)
            {
                return $"Массив образует арифметическую прогрессию с разностью {difference}";
            }
            return "Массив не образует арифметическую прогрессию.";
        }
    }
}