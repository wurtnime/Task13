using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task9
    {
        public string Execute(int[] array)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i] / 10;
            }

            return $"Массив старших разрядов: {string.Join(" ", newArray)}";
        }
    }
}