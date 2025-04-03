using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task25
    {
        public string Execute(int[] array)
        {
            int firstElement = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[^1] = firstElement;

            int sumBefore = array.Sum();
            int sumAfter = array.Sum();

            return $"Массив после сдвига: {string.Join(" ", array)}, Сумма до сдвига: {sumBefore}, сумма после сдвига: {sumAfter}";
        }
    }
}