using System;

namespace Calculadora
{
    public class operacoes
    {
        public static int Somar(int primeiroValor, int segundoValor)
        {
            var x = primeiroValor + segundoValor;
            return x;
        }

        public static int Subtrair(int primeiroValor, int segundoValor)
        {
            var x = primeiroValor - segundoValor;
            return x;
        }

        public static int Dividir(int primeiroValor, int segundoValor)
        {
            var x = primeiroValor / segundoValor;
            return x;
        }

        public static double Multiplicar(int primeiroValor, int segundoValor)
        {
            var x = primeiroValor * segundoValor;
            return x;
        }

        public static double Raiz(int primeiroValor)
        {
            var x = Math.Sqrt(primeiroValor);
            return x;
        }

        public static double Expoente(double primeiroValor, double segundoValor)
        {
            var x = Math.Pow(primeiroValor, segundoValor);
            return x;
        }
    }
}