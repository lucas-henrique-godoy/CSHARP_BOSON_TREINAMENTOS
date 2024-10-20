using System;

namespace Passgem_Por_Valor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            //chamando método
            quadrado(numero);
            //Mostrando que a variável original não foi alterada:
            Console.WriteLine("O número digitado foi {0}", numero);
        }

        public static void quadrado(int num1)
        {
            int quad = num1 * num1;
            Console.WriteLine(quad.ToString());
        }
    }
}
