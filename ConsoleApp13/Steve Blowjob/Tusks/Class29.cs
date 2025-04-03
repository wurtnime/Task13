using System;

class Class29
{
    public static void Run()
    {
        string positiveBinary = "1010"; 
        string negativeBinary = "1101"; 

        int positiveDecimal = Convert.ToInt32(positiveBinary, 2);
        int negativeDecimal = Convert.ToInt32(negativeBinary, 2);

        int sum = positiveDecimal + negativeDecimal;
        string sumBinary = Convert.ToString(sum, 2);

        Console.WriteLine($"Сумма: {sumBinary} (десятичное: {sum})");
    }
}