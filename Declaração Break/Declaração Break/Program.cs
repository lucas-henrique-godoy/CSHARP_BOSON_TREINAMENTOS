using System;

namespace Declaração_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            while (true)
            {
                Console.WriteLine("Digite um número; número 15 encerra o loop");
                numero = int.Parse(Console.ReadLine());
                if (numero == 15)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Número digitado: {0}, ", numero);
                }                
            }
            Console.WriteLine("Esta mensagem aparece após o encerramento do loop");
            
        }
    }
}
