using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task27
    {
        public string Execute(double[] array, double R)
        {
            double closestValue = array[0];
            int closestIndex = 0;
            double minDifference = Math.Abs(array[0] - R);

            for (int i = 1; i < array.Length; i++)
            {
                double difference = Math.Abs(array[i] - R);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    closestValue = array[i];
                    closestIndex = i;
                }
            }

            return $"Наиболее близкий элемент: {closestValue} (индекс: {closestIndex})";
        }
    }
}
