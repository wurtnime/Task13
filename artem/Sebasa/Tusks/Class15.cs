using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace WpfApp.Tasks
{
    public class Task15
    {
        public string Execute(string[] binaryArray)
        {
            var sortedArray = binaryArray.OrderBy(x => Convert.ToInt32(x, 2)).ToArray();
            double average = sortedArray.Average(x => Convert.ToInt32(x, 2));

            return $"Отсортированный массив: {string.Join(" ", sortedArray)}, Среднее значение: {average}";
        }
    }
}