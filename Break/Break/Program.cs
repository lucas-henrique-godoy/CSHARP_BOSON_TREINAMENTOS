using System;

namespace Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            while (true)
            {
                Console.WriteLine("Entre com um número; 15 para sair: ");
                numero = int.Parse(Console.ReadLine());
                if (numero == 15)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Número digitado foi: {0}" , numero);                    
                }
            }
            Console.WriteLine("Laço while foi encerrado! ");
        }
    }
}
