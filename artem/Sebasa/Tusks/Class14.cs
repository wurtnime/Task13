using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;

namespace WpfApp.Tasks
{
    public class Task14
    {
        public string Execute(string[] binaryArray)
        {
            var sortedArray = binaryArray.OrderByDescending(x => Convert.ToInt32(x, 2)).ToArray();
            int sum = sortedArray.Sum(x => Convert.ToInt32(x, 2));

            return $"Отсортированный массив: {string.Join(" ", sortedArray)}, Сумма: {sum}";
        }
    }
}