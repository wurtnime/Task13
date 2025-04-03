using System;

class Class18
{
    public static void Run()
    {
        int[] array = { 1, 2, 3, 2, 1, 4, 5, 6, 3, 2 };
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

        Console.WriteLine($"Разность сумм: {increasingSum - decreasingSum}");
    }
}