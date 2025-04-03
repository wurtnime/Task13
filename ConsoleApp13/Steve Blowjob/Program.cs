using System;

// Venoz paytki

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Практическая №13");
        Console.WriteLine("Выберите задание от 1 до 30:");
        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 30)
        {
            Console.WriteLine("Неверный выбор. Пожалуйста, введите число от 1 до 30.");
            return;
        }

        switch (choice)
        {
            case 1:
                Class1.Run();
                break;
            case 2:
                Class2.Run();
                break;
            case 3:
                Class3.Run();
                break;
            case 4:
                Class4.Run();
                break;
            case 5:
                Class5.Run();
                break;
            case 6:
                Class6.Run();
                break;
            case 7:
                Class7.Run();
                break;
            case 8:
                Class8.Run();
                break;
            case 9:
                Class9.Run();
                break;
            case 10:
                Class10.Run();
                break;
            case 11:
                Class11.Run();
                break;
            case 12:
                Class12.Run();
                break;
            case 13:
                Class13.Run();
                break;
            case 14:
                Class14.Run();
                break;
            case 15:
                Class15.Run();
                break;
            case 16:
                Class16.Run();
                break;
            case 17:
                Class17.Run();
                break;
            case 18:
                Class18.Run();
                break;
            case 19:
                Class19.Run();
                break;
            case 20:
                Class20.Run();
                break;
            case 21:
                Class21.Run();
                break;
            case 22:
                Class22.Run();
                break;
            case 23:
                Class23.Run();
                break;
            case 24:
                Class24.Run();
                break;
            case 25:
                Class25.Run();
                break;
            case 26:
                Class26.Run();
                break;
            case 27:
                Class27.Run();
                break;
            case 28:
                Class28.Run();
                break;
            case 29:
                Class29.Run();
                break;
            case 30:
                Class30.Run();
                break;
            default:
                Console.WriteLine("Неверный выбор. Пожалуйста, введите число от 1 до 30.");
                break;
        }
    }
}