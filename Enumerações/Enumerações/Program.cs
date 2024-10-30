using System;

namespace Enumerações
{
    internal class Program
    {
        //enum PontoCardeal { Norte = 10, Sul, Leste, Oeste }; // Definindo uma enumeração chamada PontoCardeal com valores Norte, Sul, Leste e Oeste, onde Norte começa em 10 e os demais valores são incrementais.
        enum PontoCardeal { Norte, Sul, Leste, Oeste };
        static void Main(string[] args)
        {
            PontoCardeal direcao = PontoCardeal.Norte;            
            Console.WriteLine("Ponto cardeal: " + direcao );

            // Mostrando o índice da posição do valor Norte dentro da enumeração PontoCardeal
            PontoCardeal direcao1 = PontoCardeal.Norte;
            Console.WriteLine("Ponto cardeal: " + (int)direcao1);
            
        }
    }
}
