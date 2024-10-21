using System;

namespace SobrecargaMétodos
{
    internal class Program
    {
        // Exemplo de sobrecarga de métodos, onde temos o mesmo método relizando ações diferentes com parâmetros diferentes.
        static void Main(string[] args)
        {
            // Usando o mesmo método potencia com 1 parâmetro.
            double resultado;
            int num1, num2;
            Console.WriteLine("Digite um nº para calcular seu  quadrado: ");
            num1 = int.Parse(Console.ReadLine());
            resultado = potencia(num1);
            Console.WriteLine("O qadrado de {0} é {1}", num1, resultado);

            Console.WriteLine(); // Pula 1 inha

            // Usando o mesmo método potencia com 2 parâmetros.
            Console.WriteLine("Digite dois nºs para calcular x ^ y: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            resultado = potencia(num1, num2);
            Console.WriteLine("{0} elevado a {1} é {2}", num1, num2, resultado);

            Console.ReadLine();
        }

        // Método potencia com 1 parâmetro.
        public static double potencia(int valor1)
        {
            return valor1 * valor1;
        }

        // Método potencia com 2 parâmetros.
        public static double potencia(int valor1, int valor2)
        {
            return Math.Pow(valor1, valor2);
        }
    }
}
