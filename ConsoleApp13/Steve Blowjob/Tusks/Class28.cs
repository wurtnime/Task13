using System;

class Class28
{
    public static void Run()
    {
        string[] binaryArray = { "101", "110", "1001", "11", "1010" };
        string D = "100";
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

        Console.WriteLine($"Наиболее удаленный элемент: {farthestBinary} (индекс: {farthestIndex})");
    }
}