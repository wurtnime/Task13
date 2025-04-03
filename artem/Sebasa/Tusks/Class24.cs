using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task24
    {
        public string Execute(int[] array)
        {
            int lastElement = array[^1];

            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastElement;

            return $"Массив после сдвига: {string.Join(" ", array)}";
        }
    }
}