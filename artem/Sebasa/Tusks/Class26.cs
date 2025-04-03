using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task26
    {
        public string Execute(int[] array)
        {
            int binaryNumber = Convert.ToInt32("1010", 2); 

            for (int i = 0; i < array.Length; i++)
            {
                array[i] += binaryNumber;
            }

            return $"Массив после увеличения: {string.Join(" ", array)}";
        }
    }
}