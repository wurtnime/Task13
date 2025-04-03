using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task28
    {
        public string Execute(string[] binaryArray, string D)
        {
            int decimalD = Convert.ToInt32(D, 2);
            string farthestBinary = binaryArray[0];
            int farthestIndex = 0;
            int maxDifference = Math.Abs(Convert.ToInt32(binaryArray[0], 2) - decimalD);

            for (int i = 1; i < binaryArray.Length; i++)
            {
                int difference = Math.Abs(Convert.ToInt32(binaryArray[i], 2) - decimalD);
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                    farthestBinary = binaryArray[i];
                    farthestIndex = i;
                }
            }

            return $"Наиболее удаленный элемент: {farthestBinary} (индекс: {farthestIndex})";
        }
    }
}