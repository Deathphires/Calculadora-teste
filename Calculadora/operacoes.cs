using System;



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
        public static int Dividir(int primeiroValor, int segundoValor) {
            return primeiroValor / segundoValor;
        }
        public static int Multiplicar(int primeiroValor, int segundoValor)
        {
            return primeiroValor * segundoValor;
        }
        public static double Potenciacao (double primeiroValor, double segundoValor)
        {
            return Math.Pow(primeiroValor, segundoValor);
        }
        public static double Raiz (int primeiroValor)
        {
            return Math.Sqrt(primeiroValor);
        }
        public static double Expoente(double primeiroValor)
        {
            return Math.Exp(primeiroValor);
        }


    }

