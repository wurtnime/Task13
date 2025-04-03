using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task30
    {
        public string Execute(int[] decimalArray)
        {
            string[] binaryArray = new string[decimalArray.Length];

            for (int i = 0; i < decimalArray.Length; i++)
            {
                binaryArray[i] = Convert.ToString(decimalArray[i], 2);
            }

            return $"Массив в двоичной системе: {string.Join(" ", binaryArray)}";
        }
    }
}