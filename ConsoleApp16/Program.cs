using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
        class Program
        {

            delegate void MathOperation(double a, double b);

            static void Add(double a, double b)
            {
                Console.WriteLine($"Сложение: {a} + {b} = {a + b}");
            }

            static void Subtract(double a, double b)
            {
                Console.WriteLine($"Вычитание: {a} - {b} = {a - b}");
            }

            static void Multiply(double a, double b)
            {
                Console.WriteLine($"Умножение: {a} * {b} = {a * b}");
            }

            static void Divide(double a, double b)
            {
                if (b != 0)
                    Console.WriteLine($"Деление: {a} / {b} = {a / b}");
                else
                    Console.WriteLine("Ошибка: деление на ноль.");
            }

            static void Main(string[] args)
            {
                double num1 = 10;
                double num2 = 5;

                MathOperation operation;

                operation = Add;
                operation(num1, num2);

                operation = Subtract;
                operation(num1, num2);

                operation = Multiply;
                operation(num1, num2);

                operation = Divide;
                operation(num1, num2);

                Console.ReadLine();
            }
        }
    }
