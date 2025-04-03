using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task23
    {
        public string Execute(int[] array)
        {
            int maxIndex = Array.IndexOf(array, array.Max());
            int minIndex = Array.IndexOf(array, array.Min());

            if (Math.Abs(maxIndex - minIndex) <= 1)
            {
                return "Между максимальным и минимальным элементами нет чисел.";
            }

            int count = Math.Abs(maxIndex - minIndex) - 1;
            return $"Количество чисел между максимальным и минимальным элементами: {count}";
        }
    }
}