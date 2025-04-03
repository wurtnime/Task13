using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace WpfApp.Tasks
{
    public class Task10
    {
        public string Execute(double[] array1, double[] array2)
        {
            double[] combinedArray = array1.Concat(array2).OrderByDescending(x => x).ToArray();
            return $"Объединенный и отсортированный массив: {string.Join(" ", combinedArray)}";
        }
    }
}