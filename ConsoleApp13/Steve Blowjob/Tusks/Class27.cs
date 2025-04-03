using System;

class Class27
{
    public static void Run()
    {
        double[] array = { 1.2, 3.4, 5.6, 7.8, 9.0 };
        double R = 4.5;
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

        Console.WriteLine($"Наиболее близкий элемент: {closestValue} (индекс: {closestIndex})");
    }
}