using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task20
    {
        public string Execute(int[] array)
        {
            if (array.Length < 2)
            {
                return "Массив слишком мал для проверки.";
            }

            double ratio = (double)array[1] / array[0];
            bool isGeometric = true;

            for (int i = 1; i < array.Length; i++)
            {
                if ((double)array[i] / array[i - 1] != ratio)
                {
                    isGeometric = false;
                    break;
                }
            }

            if (isGeometric)
            {
                return $"Массив образует геометрическую прогрессию со знаменателем {ratio}";
            }
            return "Массив не образует геометрическую прогрессию.";
        }
    }
}