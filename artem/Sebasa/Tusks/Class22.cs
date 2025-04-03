using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task22
    {
        public string Execute(int[] array)
        {
            int lastIndex = -1;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i] < array[i + 1])
                {
                    lastIndex = i;
                }
            }

            if (lastIndex != -1)
            {
                return $"Номер последнего элемента, удовлетворяющего условию: {lastIndex}";
            }
            return "Таких элементов нет.";
        }
    }
}