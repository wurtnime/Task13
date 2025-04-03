using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task8
    {
        public string Execute(string[] octalArray)
        {
            int[] decimalArray = new int[octalArray.Length];

            for (int i = 0; i < octalArray.Length; i++)
            {
                decimalArray[i] = Convert.ToInt32(octalArray[i], 8);
            }

            return $"Десятичный массив: {string.Join(" ", decimalArray)}";
        }
    }
}