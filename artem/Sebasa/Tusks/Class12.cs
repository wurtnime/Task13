using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task12
    {
        public string Execute(int[] array)
        {
            int firstIndex = -1, secondIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        firstIndex = i;
                        secondIndex = j;
                        break;
                    }
                }
                if (firstIndex != -1) break;
            }

            if (firstIndex != -1)
            {
                return $"Одинаковые элементы найдены на позициях: {firstIndex} и {secondIndex}";
            }
            return "Одинаковые элементы не найдены.";
        }
    }
}