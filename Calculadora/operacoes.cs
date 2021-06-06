using System;

namespace Calculadora
{
    public class operacoes
    {
        public static int Somar(int primeiroValor, int segundoValor)
        {
            return primeiroValor + segundoValor;
            
        }

        public static int Subtrair(int primeiroValor, int segundoValor)
        {
            return primeiroValor - segundoValor;
        }

        public static int Dividir(int primeiroValor, int segundoValor)
        {
            return primeiroValor / segundoValor;
        }

        public static int Multiplicar(int primeiroValor, int segundoValor)
        {
            return primeiroValor * segundoValor;
        }
    }
}