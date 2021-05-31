using Calculadora;
using System;
using System.Activities.Expressions;
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
            var first = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: ");
            var second = Int32.Parse(Console.ReadLine());
            var operacao = ("Digite 1 para fazer uma divisão, 2 para multiplicação, 3 para soma e 4 para subtração: ");
            if (operacao = 1)
            {
                var resultado = first + second;
                Console.WriteLine(first + " + " + second + " = " + resultado);
            }
            else if (operacao = 2)
            {
                var resultado = first - second;
                Console.WriteLine(first + " - " + second + " = " + resultado);
            }
            else if (operacao = 3)
            {
                var resultado = first / second;
                Console.WriteLine(first + " / " + second + " = " + resultado);
            }
            else if (operacao = 4)
            {
                var resultado = first * second;
                Console.WriteLine(first + " * " + second + " = " + resultado);
            }
            
        }
    }
}