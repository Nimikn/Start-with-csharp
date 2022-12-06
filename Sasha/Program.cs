using System;

namespace Sasha
{
    class Program
    {
        static void Main(string[] args)
        {
            double first;
            double second;
            string oper;

            Console.WriteLine("Введите первое значение");
            first = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе значение");
            second = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите оператор: + - * / %");
            oper = Console.ReadLine();
            switch (oper) 
            {
                case "+":
                    Console.WriteLine(first + second);
                    break;

                case "-":
                    Console.WriteLine(first - second);
                    break;


                case "*":
                    Console.WriteLine(first * second);
                    break;

                case "/":
                    Console.WriteLine(first / second);
                    break;

                case "%":
                    Console.WriteLine(first % second);
                    break;

                default:
                    Console.WriteLine("Эт шо такое, эт не правильно так, ты что-ли в глаза это самое делаешь, это так не пойдёт, давай ещё раз");
                    break;
            }
            Console.ReadKey();
        }
    }
}