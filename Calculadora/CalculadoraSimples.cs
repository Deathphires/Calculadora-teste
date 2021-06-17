﻿using System;



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro número: ");
            var first = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\r\nSegundo número: ");
            var second = Int32.Parse(Console.ReadLine());
            Console.WriteLine(
                "\r\nDigite:\r\n1 para fazer uma soma,\r\n2 para subtração,\r\n3 para divisão,\r\n" +
                "4 para multiplicação,\r\nou\r\n5 para potenciação:\r\n");
            var operacao = Console.ReadLine();
            if (operacao == "1")
            {
                var resultado = operacoes.Somar(first, second);
                Console.WriteLine("\r\n" + first + " + " + second + " = " + resultado);
            }
            else if (operacao == "2")
            {
                var resultado = operacoes.Subtrair(first, second);
                Console.WriteLine("\r\n" + first + " - " + second + " = " + resultado);
            }
            else if (operacao == "3")
            {
                var resultado = operacoes.Dividir(first, second);
                Console.WriteLine("\r\n" + first + " / " + second + " = " + resultado);
            }
            else if (operacao == "4")
            {
                var resultado = operacoes.Multiplicar(first, second);
                Console.WriteLine("\r\n" + first + " * " + second + " = " + resultado);
            }
            else if (operacao == "5")
            {
                var resultado = operacoes.Potenciacao(first, second);
                Console.WriteLine("\r\n" + first + " elevado a " + second + " é igual a " + resultado);
            }
            else if (operacao == "6")
            {
                var resultado = operacoes.Raiz(first);
                Console.WriteLine("\r\na raiz quadrada de " + first + " é igual a " + resultado);
            }
            else if (operacao == "7")
            {
                var resultado = operacoes.Expoente(first);
                Console.WriteLine(resultado);
            }
            
                
        }
    }
