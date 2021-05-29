using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro número: ");
            int first = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            int second = Int32.Parse(Console.ReadLine());
            int result = first + second;
            Console.WriteLine(first + " + " + second + " = " + result);
            result = first - second;
            Console.WriteLine(first + " - " + second + " = " + result);
            result = first / second;
            Console.WriteLine(first + " / " + second + " = " + result);
            result = first * second;
            Console.WriteLine(first + " * " + second + " = " + result);
        }
    }
}
