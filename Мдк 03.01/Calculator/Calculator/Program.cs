using System;

class Program
{
    static void Main()
    {
        double a = 0, b = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1. Ввести A");
            Console.WriteLine("2. Ввести B");
            Console.WriteLine("3. Выполнить операцию '+'");
            Console.WriteLine("4. Выполнить операцию '-'");
            Console.WriteLine("5. Выполнить операцию '*'");
            Console.WriteLine("6. Выполнить операцию '/'");
            Console.WriteLine("7. Выход");

            int choice = GetIntInput();

            switch (choice)
            {
                case 1:
                    a = InputNumber("Введите значение A: ");
                    break;
                case 2:
                    b = InputNumber("Введите значение B: ");
                    break;
                case 3:
                    if (b == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль");
                    }
                    else
                    {
                        Console.WriteLine($"A / B = {a / b}");
                    }
                    break;
                case 4:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    break;
            }
            Console.WriteLine();
        }
    }

    static double InputNumber(string message)
    {
        Console.Write(message);
        return GetDoubleInput();
    }

    static int GetIntInput()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Неверный ввод. Введите целое число.");
        }
        return value;
    }

    static double GetDoubleInput()
    {
        double value;
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Неверный ввод. Введите число.");
        }
        return value;
    }
}
