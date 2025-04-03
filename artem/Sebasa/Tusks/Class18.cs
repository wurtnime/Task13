using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Tasks
{
    public class Task18
    {
        public string Execute(int[] array)
        {
            int increasingSum = 0, decreasingSum = 0;
            int currentSum = array[0];
            bool isIncreasing = true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    if (!isIncreasing)
                    {
                        decreasingSum += currentSum;
                        currentSum = 0;
                    }
                    isIncreasing = true;
                }
                else if (array[i] < array[i - 1])
                {
                    if (isIncreasing)
                    {
                        increasingSum += currentSum;
                        currentSum = 0;
                    }
                    isIncreasing = false;
                }
                currentSum += array[i];
            }

            if (isIncreasing)
            {
                increasingSum += currentSum;
            }
            else
            {
                decreasingSum += currentSum;
            }

            return $"Разность сумм: {increasingSum - decreasingSum}";
        }
    }
}