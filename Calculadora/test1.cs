namespace Calculadora
{
    public class test1
    {
        public float percentage(int number, int percentual)
        {
            var resultado = operacoes.Somar(number, 100);
            return resultado / percentual * 100;
        }
    }
}