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
            Console.WriteLine("Digite 1 para fazer uma soma, 2 para subtração, 3 para divisão, 4 para multiplicação, 5 para raiz quadrada do primeiro valor e 6 para expoente: ");
            var operacao = Console.ReadLine();
            if (operacao == "1")
            {
               var resultado = operacoes.Somar(first, second);
               Console.WriteLine(first + " + " + second + " = " + resultado);
            }
            else if (operacao == "2")
            {
                var resultado = operacoes.Subtrair(first, second);
                Console.WriteLine(first + " - " + second + " = " + resultado);
            }
            else if (operacao == "3")
            {
                var resultado = operacoes.Dividir(first, second);
                Console.WriteLine(first + " / " + second + " = " + resultado);
            }
            else if (operacao == "4")
            {
                var resultado = operacoes.Multiplicar(first, second);
                Console.WriteLine(first + " * " + second + " = " + resultado);
            }
            else if (operacao == "5")
            {
                var resultado = operacoes.Raiz(first);
                Console.WriteLine("raiz quadrada de " + first + " é =" + resultado); //num meche no que tá quieto
            }
            else if (operacao == "6")
            {
                var resultado = operacoes.Expoente(first, second);
                Console.WriteLine(first + " elevado à " + second + "ª potência " + "é =" + resultado);
            }
        }
    }
}