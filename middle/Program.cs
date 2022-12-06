using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middle
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second, third, fourth, fifth;
            Console.WriteLine("Введите первое значение");
            first = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе значение");
            second = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третие значение");
            third = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите четвёртое значение");
            fourth = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите пятое значение");
            fifth = Double.Parse(Console.ReadLine());

            Console.WriteLine((first + second + third + fourth + fifth)/5);
        }
    }
}
