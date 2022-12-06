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
            int a;
            Console.WriteLine("ну короче опять эти числа вводить, короче ты уже знаешь что делать");
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("чётное");
            }
            else
            {
                Console.WriteLine("нечётное");
            }
        }
    }
}