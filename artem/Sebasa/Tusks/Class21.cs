using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace WpfApp.Tasks
{
    public class Task21
    {
        public string Execute(int[] array)
        {
            List<int> indices = new List<int>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    indices.Add(i);
                }
            }

            return $"Индексы элементов, больших, чем справа: {string.Join(" ", indices)}, Количество: {indices.Count}";
        }
    }
}