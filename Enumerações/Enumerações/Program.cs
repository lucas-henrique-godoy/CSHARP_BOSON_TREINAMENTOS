using System;

namespace Enumerações
{
    internal class Program
    {
        enum PontoCardeal { Norte, Sul, Leste, Oeste };
        static void Main(string[] args)
        {
            PontoCardeal direcao = PontoCardeal.Norte;            
            Console.WriteLine("Ponto cardeal: " + direcao );
        }
    }
}
