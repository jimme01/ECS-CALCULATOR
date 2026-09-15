using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS_Calculator.Operations;

namespace ECS_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Консольний калькулятор v1.2 (додавання/віднімання)");
           Console.WriteLine("Введіть вираз у форматі: число1 оператор число2 (наприклад: 5 + 3)");
           Console.WriteLine("Підтримувані оператори: +, -, *, /, ^, %");
           Console.WriteLine("Для виходу введіть 'exit'.");

            while (true)
            {
                Console.Write("Введіть вираз: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Помилка: Вираз не може бути порожнім.");
                    continue;
                }
                string[] parts = input.Trim().Split(' ');
                if (parts.Length != 3)
                {
                    Console.WriteLine("Помилка: Вираз повинен містити два числа та один оператор.");
                    continue;
                }
                if (!double.TryParse(parts[0], out double number1) || !double.TryParse(parts[2], out double number2))
                {
                    Console.WriteLine("Помилка: Обидва числа повинні бути дійсними числами.");
                    continue;
                }
                string op = parts[1];
                double result;

                switch (op)
                {
                    case "+":
                        result = AddSubtract.Add(number1, number2);
                        Console.WriteLine($"Результат: {result}");
                        break;
                    case "-":
                        result = AddSubtract.Subtract(number1, number2);
                        Console.WriteLine($"Результат: {result}");
                        break;
                    case "*":
                        result = MultiplyDivide.Multiply(number1, number2);
                        Console.WriteLine($"Результат: {result}");
                        break;
                    case "/":
                        if (number2 == 0)
                        {
                            Console.WriteLine("Помилка: Ділення на нуль неможливе.");
                            continue;
                        }
                        result = number1 / number2;
                        Console.WriteLine($"Результат: {result}");
                        break;
                    case "^":
                        result = PowerModulo.Power(number1, number2);
                        Console.WriteLine($"Результат: {result}");
                        break;
                    case "%":
                        if (number2 == 0)
                        {
                            Console.WriteLine("Помилка: Ділення на нуль неможливе.");
                            continue;
                        }
                        result = PowerModulo.Modulo(number1,number2);
                        Console.WriteLine($"Результат: {result}");
                        break;
                    default:
                        Console.WriteLine("Помилка: Непідтримуваний оператор.");
                        break;
                }
                Console.WriteLine("Результат: " + result);
            }
        }
        
    }
}
