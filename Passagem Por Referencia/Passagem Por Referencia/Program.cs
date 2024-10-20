using System;

namespace Passagem_Por_Referencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            incrementa(ref numero);
            Console.WriteLine("O valor incrementado é: {0}", numero);
        }

        static void incrementa(ref int valor)
        {
            valor++;
        }
       

    }
}
