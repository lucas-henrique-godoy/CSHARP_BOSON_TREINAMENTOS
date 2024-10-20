using System;
using System.Threading;

namespace Métodos
{
    internal class Program
    {
        static void Main(string[] args) // Static - não preciso criar uma instânciada classe para usar esse método
        {
            int soma;
            int valor1;
            int valor2;

            Console.WriteLine("Digite um número: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            valor2 = int.Parse(Console.ReadLine());
            soma = somaNumeros(valor1, valor2);
            Console.WriteLine("A soma é: {0}", soma.ToString());
        }
        // Método para somar dois números:
        static int somaNumeros(int num1,int num2)
        {
            int resultado = num1 + num2;
            return resultado;
           
        }
    }
}
