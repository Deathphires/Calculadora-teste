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
            Console.WriteLine(
                "Digite 1 para fazer uma soma, 2 para subtração, 3 para divisão e 4 para multiplicação: ");
            var operacao = Console.ReadLine();
            if (operacao == "1")
            {
               var resultado = operacoes.Somar(first, second);
               Console.WriteLine(first + " + " + second + " = " + resultado);
            }
            else if (operacao == "2")
            {
                var resultado = first - second;
                Console.WriteLine(first + " - " + second + " = " + resultado);
            }
            else if (operacao == "3")
            {
                var resultado = first / second;
                Console.WriteLine(first + " / " + second + " = " + resultado);
            }
            else if (operacao == "4")
            {
                var resultado = first * second;
                Console.WriteLine(first + " * " + second + " = " + resultado);
            }
        }
    }
}