using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Выход");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите число от 1 до 5.");
                    continue;
                }

                if (choice == 5)
                {
                    break;
                }

                Console.Write("Введите первое число: ");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
                    continue;
                }

                Console.Write("Введите второе число: ");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
                    continue;
                }

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = Add(num1, num2);
                        break;
                    case 2:
                        result = Subtract(num1, num2);
                        break;
                    case 3:
                        result = Multiply(num1, num2);
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            result = Divide(num1, num2);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите число от 1 до 5.");
                        continue;
                }

                Console.WriteLine($"Результат: {result}");
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
